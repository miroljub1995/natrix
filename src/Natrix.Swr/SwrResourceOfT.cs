using Natrix.Core.Hooks;
using Natrix.Signals;

namespace Natrix.Swr;

/// <summary>
/// One component's view of one key: reactive state to render from, and the two imperative
/// operations React SWR exposes on its response — revalidate and mutate.
///
/// Created by <see cref="SwrResource.Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, SwrOptions?)"/>
/// during <c>Setup</c>, and bound to that component: it follows the component's key as it
/// changes, releases the entry when the component unmounts, and starts fetching when it mounts.
/// </summary>
/// <remarks>
/// <para>
/// <b>Nothing is fetched during <c>Setup</c>.</b> The first request is issued from an
/// <see cref="LifecycleHooks.OnMounted"/> hook, which means server-side rendering — where hooks
/// are dropped because there is no live tree — renders the loading state and leaves the fetching
/// to the client. That is also what keeps hydration consistent: the client's first render
/// happens before mounted hooks flush, so it matches the server's markup, and data arrives
/// afterwards.
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
    private readonly Func<SwrKey, CancellationToken, Task<TData>> _fetcher;
    private readonly SwrOptions _options;

    /// <summary>
    /// The bound entry, as a signal so the projections below re-read when the key changes, and
    /// as a field so the resource's own bookkeeping can touch it without registering as a
    /// dependent.
    /// </summary>
    private readonly Signal<SwrCacheEntry<TData>?> _entrySignal = new(null);

    private SwrCacheEntry<TData>? _entry;
    private SwrKey _key = SwrKey.None;
    private bool _bound;

    /// <summary>
    /// Gates fetching until the component is live. Key changes evaluated before that — including
    /// the first one, during <c>Setup</c> — only bind, they do not fetch.
    /// </summary>
    private bool _mounted;

    internal SwrResource(
        SwrCache cache,
        Func<SwrKey> keyFactory,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions options)
    {
        _cache = cache;
        _fetcher = fetcher;
        _options = options;

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

        // Re-runs whenever a signal read by the key factory changes, which is what makes a
        // resource follow, say, a route parameter from one key to the next.
        new Effect(_ =>
        {
            var key = keyFactory();

            using var untracked = new UntrackedScope();
            Bind(key);
        });

        // Tracks nothing; exists only so the component's scope releases the entry on unmount.
        new Effect(onCleanup => onCleanup(Release));

        LifecycleHooks.OnMounted(onCleanup =>
        {
            _mounted = true;
            _ = RevalidateAsync();
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

    private void Bind(SwrKey key)
    {
        // The key factory re-runs whenever anything it read changed, which is not the same as
        // the key having changed. Rebinding an unchanged key would drop and re-take the entry,
        // cancelling its request on the way through.
        if (_bound && _key == key)
        {
            return;
        }

        Release();

        _bound = true;
        _key = key;

        if (!key.HasValue)
        {
            _entrySignal.Value = null;
            return;
        }

        var entry = _cache.GetOrCreate<TData>(key);
        entry.AddSubscriber();

        _entry = entry;
        _entrySignal.Value = entry;

        if (_mounted)
        {
            _ = entry.RevalidateAsync(_fetcher, _options, force: false);
        }
    }

    /// <summary>
    /// Gives up the claim on the bound entry. Only the claim is released — the signal keeps
    /// pointing at the entry so that a resource being torn down does not push a spurious "no
    /// data" through the tree on its way out. <see cref="Bind"/> overwrites it right after.
    /// </summary>
    private void Release()
    {
        _entry?.RemoveSubscriber();
        _entry = null;
    }
}
