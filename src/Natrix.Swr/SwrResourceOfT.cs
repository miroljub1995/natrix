using System.Text.Json.Serialization.Metadata;
using Natrix.Signals;
using Natrix.Ssr.Abstractions.Features;

namespace Natrix.Swr;

/// <summary>
/// One component's view of one key: reactive state to render from, and the two imperative
/// operations React SWR exposes on its response — revalidate and mutate.
///
/// Created by <see cref="SwrResource.Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
/// during <c>Setup</c>, and bound to that component: it follows the component's key as it
/// changes, fetches for each key it binds, and releases the entry when the component unmounts.
/// </summary>
/// <remarks>
/// <para>
/// <b>Nothing is fetched synchronously during <c>Setup</c>.</b> In the browser, binding a key
/// starts its request at once, but the request itself yields to the event loop before it calls
/// the fetcher — see <see cref="SwrRun{TData}"/>. Setup runs inside the parent's render, and a
/// fetcher that completed on the spot would otherwise write the entry's signals into the middle
/// of it — and hand the first client render a value the server's markup never had.
/// </para>
/// <para>
/// <b>Server rendering fetches only through the prefetch queue</b>, and only when
/// <see cref="SwrOptions.FetchOnServer"/> is on. Binding a key there registers a prefetch the
/// render waits for, and the value is serialized into the page for the client to pick up — so the
/// first client render matches the markup, and the components hydrating from that value do not
/// revalidate it. A client-only resource registers nothing and fetches in the browser.
/// </para>
/// <para>
/// The signals here are per-resource projections of shared cache state. Two components using the
/// same key read the same underlying entry, so one component's fetch fills in the other's
/// <see cref="Data"/>.
/// </para>
/// </remarks>
public sealed class SwrResource<TData>
{
    private readonly Func<SwrKey, CancellationToken, Task<TData>> _fetcher;
    private readonly SwrOptions _options;

    /// <summary>
    /// The bound entry, for the imperative operations. Kept apart from the signal the projections
    /// read so that those operations never register as dependents, and so that releasing a claim
    /// can clear this without pushing a spurious "no data" through a tree on its way out.
    /// </summary>
    private SwrCacheEntry<TData>? _entry;

    internal SwrResource(
        SwrFeature feature,
        Func<SwrKey> keyFactory,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions options,
        IServerPrefetchFeature? serverPrefetch)
    {
        _fetcher = fetcher;
        _options = options;

        var cache = feature.Cache;

        // Resolved at the Use call that introduced the type rather than at the render that would
        // have transferred it, so a type the shared context does not cover is reported against
        // the code that asked for it.
        var typeInfo = cache.GetTypeInfo<TData>();

        // The bound entry as a signal, so the projections below re-read when the key changes.
        var entrySignal = new Signal<SwrCacheEntry<TData>?>(null);

        Data = new Computed<TData?>(() => entrySignal.Value is { } entry ? entry.State.Value.Data : default);
        Error = new Computed<Exception?>(() => entrySignal.Value?.State.Value.Error);
        Key = new Computed<SwrKey>(() => entrySignal.Value?.Key ?? SwrKey.None);

        // In the browser a binding starts its request on the spot, so the entry's own run is the
        // whole answer. On the server the request for a bound key that has no value is still to
        // come — from the prefetch drain, or for a client-only resource from the browser, which
        // binds the key with nothing in the payload for it and fetches — so "no value yet" is
        // "being fetched", and the render shows the skeleton rather than an empty state the
        // client's first render would never reproduce. Once the value is there, whichever
        // resource prefetched it, the client hydrates it without a request, and this agrees.
        var isServer = serverPrefetch is not null;

        IsValidating = new Computed<bool>(() =>
            entrySignal.Value is { } entry
            && (entry.IsValidating.Value || (isServer && !entry.State.Value.HasData)));

        // React SWR's definition: a request for a key that has no value yet. A subset of
        // IsValidating — the same request, minus the ones that only refresh what is already on
        // screen. An error is not a value, so a retry after a failure loads again.
        IsLoading = new Computed<bool>(() =>
            IsValidating.Value && entrySignal.Value is { } entry && !entry.State.Value.HasData);

        // Through a computed rather than straight off the factory, because the two answer
        // different questions: the factory re-runs whenever anything it read changed, while the
        // computed only reports a change when the key it produced actually differs. Binding cares
        // about the second — a signal that moves without moving the key must leave the entry and
        // its request in flight exactly where they are.
        var key = new Computed<SwrKey>(keyFactory);

        // Encoding is the expensive comparison and the authoritative one, so it goes in a second
        // layer fed by the first: the cheap structural check above absorbs the factory runs that
        // changed nothing, and a key is serialized only when its segments really moved. What
        // comes out is compared as a string, so the two keys that differ only in a segment's
        // declared type — an int and a long holding 1 — leave the binding alone, as they must:
        // they share the entry, and rebinding would cancel its request.
        var keyEncoder = cache.KeyEncoder;
        var encodedKey = new Computed<SwrEncodedKey>(() =>
        {
            var current = key.Value;
            return new SwrEncodedKey(current, keyEncoder.Encode(current));
        });

        // Takes a claim on the entry for the current key and releases it when the key moves on or
        // the component's scope disposes the effect. Only ever runs with a key that differs from
        // the one bound, since it watches a computed.
        new Effect(onCleanup =>
        {
            var current = encodedKey.Value;

            using var untracked = new UntrackedScope();

            // A paused resource takes no claim, and so has nothing to release.
            if (!current.HasValue)
            {
                entrySignal.Value = null;
                return;
            }

            var entry = cache.GetOrCreate(current, typeInfo);
            entry.AddSubscriber();

            _entry = entry;
            entrySignal.Value = entry;

            if (serverPrefetch is not null)
            {
                // On the server the fetcher runs only through the prefetch queue, which the render
                // waits for. A request started here would outlive the response, and the prefetch
                // registered after it would join it and inherit its retries. Registered per bind
                // rather than once: a prefetch that moves a signal can change the key, and the
                // drain picks up whatever the new binding registers. A client-only resource
                // registers nothing, which leaves the entry empty: the markup shows the loading
                // state, the payload carries no value for the key, and the client's first render
                // agrees before it fetches.
                if (options.FetchOnServer)
                {
                    serverPrefetch.Register(() => entry.EnsureLoadedAsync(fetcher, options));
                }
            }
            else
            {
                // A key bound while the page hydrates, whose value came from the page, renders
                // what the server rendered — as fresh as the markup, nothing to fetch. Every other
                // bind revalidates: one after the pass, a second component on a key the page
                // carried included, and one during the pass on a value the cache held from before
                // it. Hydration covers the render that reproduces the markup, nothing else.
                var hydrated = cache.IsHydrating && entry.IsHydrated;

                if (!hydrated)
                {
                    // Started here, inside the parent's render, which is safe because the run
                    // yields before it calls the fetcher: the only thing written into the render
                    // is the entry's "in flight" state. A request already running for the key is
                    // joined instead. If the key moves on before the cycle, releasing the claim
                    // cancels the run — unless another component still holds the key, in which
                    // case the request is theirs. Not awaited: it never faults on this path, and
                    // the entry owns its lifetime.
                    _ = entry.RevalidateAsync(fetcher, options);
                }
            }

            onCleanup(() =>
            {
                // Only the claim is given up — the signal keeps pointing at the entry so that a
                // resource being torn down does not push a spurious "no data" through the tree
                // on its way out. A rebind overwrites it right after.
                entry.RemoveSubscriber();
                _entry = null;
            });
        });
    }

    /// <summary>
    /// The cached value for the current key, or <c>default</c> when nothing has been fetched yet.
    /// Kept in place while a revalidation runs, and kept after a failed one — that is the "stale"
    /// in stale-while-revalidate.
    /// </summary>
    public IReadOnlySignal<TData?> Data { get; }

    /// <summary>
    /// The last error for the current key, cleared by the next successful fetch. Set only once a
    /// request has given up: while retries are still to come the key is loading, not failed.
    /// </summary>
    public IReadOnlySignal<Exception?> Error { get; }

    /// <summary>
    /// A request is pending or in flight for the current key and there is no value for it yet:
    /// the initial load, as opposed to a refresh of data already on screen. Always a subset of
    /// <see cref="IsValidating"/>. Stays <c>true</c> through a request's retries, and is
    /// <c>true</c> again while an explicit revalidation runs after an error. Always <c>false</c>
    /// for an absent key.
    /// </summary>
    public IReadOnlySignal<bool> IsLoading { get; }

    /// <summary>
    /// A request for the current key is in flight, including the gaps between error retries.
    /// <c>true</c> from the moment a key that will be fetched is bound until that request
    /// succeeds or gives up. On the server, also <c>true</c> for a bound key with no value yet:
    /// its request is coming, from the prefetch drain or from the browser.
    /// </summary>
    public IReadOnlySignal<bool> IsValidating { get; }

    /// <summary>
    /// The key currently bound, as last produced by the key factory.
    /// <see cref="SwrKey.None"/> while paused.
    /// </summary>
    public IReadOnlySignal<SwrKey> Key { get; }

    /// <summary>
    /// Refetches the current key, or joins the request already in flight for it. A no-op while
    /// paused. The fetcher is called on the next cycle of the event loop, never before this
    /// returns.
    /// </summary>
    public Task RevalidateAsync() =>
        _entry?.RevalidateAsync(_fetcher, _options) ?? Task.CompletedTask;

    /// <summary>
    /// Writes <paramref name="data"/> into the cache for the current key, so every component
    /// using it updates at once, and by default refetches to confirm it against the server.
    /// The write is immediate; the refetch calls the fetcher on the next cycle of the event
    /// loop. A no-op while paused.
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
}
