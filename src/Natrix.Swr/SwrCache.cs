namespace Natrix.Swr;

/// <summary>
/// The store behind the "stale" half of stale-while-revalidate: it keeps the last value fetched
/// for every key, so a component that mounts, unmounts and mounts again renders immediately from
/// cache while a fresh request runs in the background.
///
/// One cache per application, registered through
/// <see cref="NatrixHostBuilderSwrExtensions.UseSwr"/>. It is deliberately not a static
/// singleton: a server rendering pass builds a host per request, and a process-wide cache there
/// would serve one visitor's data to the next.
/// </summary>
/// <remarks>
/// Entries are never evicted on their own — that is what makes the cached value outlive the
/// components using it. Long-lived apps that accumulate unbounded keys, and anything that must
/// not survive a sign-out, should call <see cref="Remove"/> or <see cref="Clear"/>.
/// </remarks>
public sealed class SwrCache
{
    private readonly Dictionary<string, ISwrCacheEntry> _entries = new(StringComparer.Ordinal);
    private readonly Lock _gate = new();

    /// <summary>
    /// Number of keys currently held.
    /// </summary>
    public int Count
    {
        get
        {
            lock (_gate)
            {
                return _entries.Count;
            }
        }
    }

    /// <summary>
    /// Drops a key. Any request in flight for it is abandoned.
    /// </summary>
    /// <remarks>
    /// Resources currently bound to the key keep the entry they already hold, and go on showing
    /// its value until their key changes or they are unmounted — a live component is not blanked
    /// out from under the user. The next resource to ask for the key gets a fresh, empty entry.
    /// </remarks>
    /// <returns><c>true</c> if the key was present.</returns>
    public bool Remove(SwrKey key)
    {
        ISwrCacheEntry? entry;
        lock (_gate)
        {
            if (!_entries.Remove(key.CacheKey, out entry))
            {
                return false;
            }
        }

        entry.CancelPending();
        return true;
    }

    /// <summary>
    /// Drops every key, abandoning requests in flight. Same caveat as <see cref="Remove"/> for
    /// resources already bound.
    /// </summary>
    public void Clear()
    {
        ISwrCacheEntry[] entries;
        lock (_gate)
        {
            entries = [.. _entries.Values];
            _entries.Clear();
        }

        foreach (var entry in entries)
        {
            entry.CancelPending();
        }
    }

    /// <summary>
    /// Returns the entry for <paramref name="key"/>, creating it on first use.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// The key is already held with a different data type. Two components fetching the same key
    /// into different shapes would silently share — and corrupt — one another's cache slot, so it
    /// is reported rather than tolerated.
    /// </exception>
    internal SwrCacheEntry<TData> GetOrCreate<TData>(SwrKey key)
    {
        lock (_gate)
        {
            if (_entries.TryGetValue(key.CacheKey, out var existing))
            {
                return existing as SwrCacheEntry<TData>
                    ?? throw new InvalidOperationException(
                        $"Cache key {key} is already used with a different data type. " +
                        $"Requested {typeof(SwrCacheEntry<TData>)}, found {existing.GetType()}.");
            }

            var entry = new SwrCacheEntry<TData>(key);
            _entries[key.CacheKey] = entry;
            return entry;
        }
    }
}
