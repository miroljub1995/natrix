using System.Text.Json.Serialization.Metadata;
using Natrix.Core.Hooks;
using Natrix.Signals;
using Natrix.Ssr.Abstractions.Features;

namespace Natrix.Swr;

/// <summary>
/// One component's view of one key: reactive state to render from, and the two imperative
/// operations React SWR exposes on its response — revalidate and mutate.
///
/// Created by <see cref="SwrResource.Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
/// during <c>Setup</c>, and bound to that component: it follows the component's key as it
/// changes, releases the entry when the component unmounts, and starts fetching when it mounts.
/// </summary>
/// <remarks>
/// <para>
/// <b>Nothing is fetched during <c>Setup</c>.</b> In the browser the first request is issued from
/// an <see cref="LifecycleHooks.OnMounted"/> hook, so a component set up and discarded before it
/// mounts costs nothing.
/// </para>
/// <para>
/// <b>Server rendering fetches too.</b> Binding a key there registers a prefetch the render waits
/// for, and the value is serialized into the page for the client to pick up — so the first client
/// render matches the markup, and a value that arrived with the page is not revalidated until the
/// components holding it have unmounted.
/// </para>
/// <para>
/// The signals here are per-resource projections of shared cache state. Two components using the
/// same key read the same underlying entry, so one component's fetch fills in the other's
/// <see cref="Data"/>.
/// </para>
/// </remarks>
public sealed class SwrResource<TData>
{
    private readonly SwrCache _cache;
    private readonly SwrKeyEncoder _keyEncoder;
    private readonly Func<SwrKey, CancellationToken, Task<TData>> _fetcher;
    private readonly SwrOptions _options;
    private readonly JsonTypeInfo<TData> _typeInfo;

    /// <summary>
    /// Present only while server rendering. When it is, binding a key enqueues a fetch the render
    /// waits for, so the markup ships with the data in it instead of a skeleton.
    /// </summary>
    private readonly IServerPrefetchFeature? _serverPrefetch;

    /// <summary>
    /// The bound entry, as a signal so the projections below re-read when the key changes, and
    /// as a field so the resource's own bookkeeping can touch it without registering as a
    /// dependent.
    /// </summary>
    private readonly Signal<SwrCacheEntry<TData>?> _entrySignal = new(null);

    private SwrCacheEntry<TData>? _entry;

    /// <summary>
    /// Gates fetching until the component is live. Key changes evaluated before that — including
    /// the first one, during <c>Setup</c> — only bind, they do not fetch.
    /// </summary>
    private bool _mounted;

    internal SwrResource(
        SwrFeature feature,
        Func<SwrKey> keyFactory,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions options,
        IServerPrefetchFeature? serverPrefetch)
    {
        _cache = feature.Cache;
        _keyEncoder = feature.KeyEncoder;
        _fetcher = fetcher;
        _options = options;
        _serverPrefetch = serverPrefetch;

        // Resolved at the Use call that introduced the type rather than at the render that would
        // have transferred it, so a type the shared context does not cover is reported against
        // the code that asked for it.
        _typeInfo = feature.GetTypeInfo<TData>();

        Data = new Computed<TData?>(() => _entrySignal.Value is { } entry ? entry.State.Value.Data : default);
        Error = new Computed<Exception?>(() => _entrySignal.Value?.State.Value.Error);
        IsValidating = new Computed<bool>(() => _entrySignal.Value?.IsValidating.Value ?? false);
        Key = new Computed<SwrKey>(() => _entrySignal.Value?.Key ?? SwrKey.None);

        // "Loading" is the absence of an outcome, not the presence of a request: a key with
        // neither data nor error has nothing to render yet, whether its request is already in
        // flight or still waiting for the component to mount. Without that, a server-rendered
        // tree — which never fetches — would show its empty state instead of its skeleton.
        IsLoading = new Computed<bool>(() =>
            _entrySignal.Value is { } entry && entry.State.Value is { HasData: false, Error: null });

        // Through a computed rather than straight off the factory, because the two answer
        // different questions: the factory re-runs whenever anything it read changed, while the
        // computed only reports a change when the key it produced actually differs. Binding cares
        // about the second — a signal that moves without moving the key must leave the entry, its
        // request in flight and its hydration freshness exactly where they are.
        var key = new Computed<SwrKey>(keyFactory);

        // Encoding is the expensive comparison and the authoritative one, so it goes in a second
        // layer fed by the first: the cheap structural check above absorbs the factory runs that
        // changed nothing, and a key is serialized only when its segments really moved. What
        // comes out is compared as a string, so the two keys that differ only in a segment's
        // declared type — an int and a long holding 1 — leave the binding alone, as they must:
        // they share the entry, and rebinding would cancel its request.
        var encodedKey = new Computed<SwrEncodedKey>(() =>
        {
            var current = key.Value;
            return new SwrEncodedKey(current, _keyEncoder.Encode(current));
        });

        // So the claim's lifetime is the encoded key's: released when the key moves on, and again
        // when the component's scope disposes the effect.
        new Effect(onCleanup =>
        {
            var current = encodedKey.Value;

            using var untracked = new UntrackedScope();
            onCleanup(Bind(current));
        });

        LifecycleHooks.OnMounted(onCleanup =>
        {
            _mounted = true;
            _ = _entry?.RevalidateOnMountAsync(_fetcher, _options);
        });
    }

    /// <summary>
    /// The cached value for the current key, or <c>default</c> when nothing has been fetched yet.
    /// Kept in place while a revalidation runs, and kept after a failed one — that is the "stale"
    /// in stale-while-revalidate.
    /// </summary>
    public IReadOnlySignal<TData?> Data { get; }

    /// <summary>
    /// The last error for the current key, cleared by the next successful fetch. Set as soon as
    /// an attempt fails, while retries may still be pending.
    /// </summary>
    public IReadOnlySignal<Exception?> Error { get; }

    /// <summary>
    /// Nothing to render yet: no value and no error for the current key. Distinct from
    /// <see cref="IsValidating"/>, which is also true while refreshing data that is already on
    /// screen. Always <c>false</c> for an absent key.
    /// </summary>
    public IReadOnlySignal<bool> IsLoading { get; }

    /// <summary>
    /// A request for the current key is in flight, including the gaps between error retries.
    /// </summary>
    public IReadOnlySignal<bool> IsValidating { get; }

    /// <summary>
    /// The key currently bound, as last produced by the key factory.
    /// <see cref="SwrKey.None"/> while paused.
    /// </summary>
    public IReadOnlySignal<SwrKey> Key { get; }

    /// <summary>
    /// Refetches the current key, or joins the request already in flight for it. A no-op while
    /// paused.
    /// </summary>
    public Task RevalidateAsync() =>
        _entry?.RevalidateAsync(_fetcher, _options, force: false) ?? Task.CompletedTask;

    /// <summary>
    /// Writes <paramref name="data"/> into the cache for the current key, so every component
    /// using it updates at once, and by default refetches to confirm it against the server.
    /// A no-op while paused.
    /// </summary>
    /// <param name="revalidate">
    /// <c>false</c> to keep the local value as-is — appropriate when the response of the write
    /// that prompted the mutation is already the authoritative value.
    /// </param>
    public Task MutateAsync(TData data, bool revalidate = true) =>
        _entry?.MutateAsync(data, revalidate, _fetcher, _options) ?? Task.CompletedTask;

    /// <summary>
    /// Mutation from the current value, for the common optimistic update that edits rather than
    /// replaces. A no-op while paused.
    /// </summary>
    public Task MutateAsync(Func<TData?, TData> update, bool revalidate = true)
    {
        ArgumentNullException.ThrowIfNull(update);

        if (_entry is not { } entry)
        {
            return Task.CompletedTask;
        }

        return entry.MutateAsync(update(entry.PeekData()), revalidate, _fetcher, _options);
    }

    /// <summary>
    /// Takes a claim on the entry for <paramref name="key"/> and hands back the undo for it,
    /// which the effect runs when the key moves on or the component goes away. The two are
    /// produced together so that neither can be reached without the other — a paused resource
    /// takes nothing and hands back nothing, rather than relying on the release to notice.
    /// </summary>
    /// <remarks>
    /// Only ever reached with a key that differs from the one bound, since the effect driving it
    /// watches a computed.
    /// </remarks>
    private Action Bind(SwrEncodedKey key)
    {
        if (!key.HasValue)
        {
            _entrySignal.Value = null;
            return static () => { };
        }

        var entry = _cache.GetOrCreate(key, _typeInfo);
        entry.AddSubscriber();

        _entry = entry;
        _entrySignal.Value = entry;

        // Registered per bind rather than once: a prefetch that moves a signal can change the
        // key, and the drain picks up whatever the new binding registers.
        _serverPrefetch?.Register(() => entry.EnsureLoadedAsync(_fetcher, _options));

        if (_mounted)
        {
            _ = entry.RevalidateOnMountAsync(_fetcher, _options);
        }

        return () =>
        {
            // Only the claim is given up — the signal keeps pointing at the entry so that a
            // resource being torn down does not push a spurious "no data" through the tree on
            // its way out. A rebind overwrites it right after.
            entry.RemoveSubscriber();
            _entry = null;
        };
    }
}
