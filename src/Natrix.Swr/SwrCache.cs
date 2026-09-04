using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;

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
    private readonly JsonSerializerOptions _serializerOptions;

    /// <summary>
    /// Values the server sent with the page, held until a component asks for the key they belong
    /// to. Deserializing lazily is what keeps the payload free of type names: the entry is
    /// created by a <c>Use</c> call that already knows its data type.
    /// </summary>
    private Dictionary<string, JsonNode?>? _pending;



    /// <param name="serializerOptions">
    /// How the cache names and stores what it holds: the contracts for the values it carries
    /// across the hydration boundary, and — through their resolver — the ones its keys are
    /// encoded under. Required, because a cache that cannot do either is a cache whose entries
    /// the browser cannot read back. Pass the <c>Options</c> of a source-generated
    /// <c>JsonSerializerContext</c> covering every fetched type, the same one on both hosts,
    /// which is what keeps the transfer trim-safe and AOT-safe.
    /// </param>
    public SwrCache(JsonSerializerOptions serializerOptions)
    {
        ArgumentNullException.ThrowIfNull(serializerOptions);

        _serializerOptions = serializerOptions;

        // The contracts come from the application, the formatting does not - see SwrKeyEncoder.
        KeyEncoder = new SwrKeyEncoder(serializerOptions.TypeInfoResolver);
    }

    /// <summary>
    /// How a key becomes the string this cache files it under.
    /// </summary>
    internal SwrKeyEncoder KeyEncoder { get; }

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
        var cacheKey = KeyEncoder.Encode(key);

        ISwrCacheEntry? entry;
        lock (_gate)
        {
            _pending?.Remove(cacheKey);

            if (!_entries.Remove(cacheKey, out entry))
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
            _pending = null;
        }

        foreach (var entry in entries)
        {
            entry.CancelPending();
        }
    }

    /// <summary>
    /// Returns the entry for <paramref name="key"/>, creating it on first use and seeding it from
    /// the server's payload when that key was rendered into the page.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// The key is already held with a different data type. Two components fetching the same key
    /// into different shapes would silently share — and corrupt — one another's cache slot, so it
    /// is reported rather than tolerated.
    /// </exception>
    /// <summary>
    /// Resolves how <typeparamref name="TData"/> crosses the hydration boundary, at the
    /// <c>Use</c> call that introduced it rather than at render time, so a type missing from the
    /// serializer context is reported against the code that asked for it.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// The configured options cannot describe <typeparamref name="TData"/>. Carrying on without
    /// it would only defer the failure to the hydration mismatch it causes.
    /// </exception>
    internal JsonTypeInfo<TData> GetTypeInfo<TData>()
    {
        try
        {
            return (JsonTypeInfo<TData>)_serializerOptions.GetTypeInfo(typeof(TData));
        }
        catch (Exception exception) when (exception is InvalidOperationException or NotSupportedException)
        {
            throw new InvalidOperationException(
                $"The serializer options in use have no metadata for {typeof(TData)}. Add "
                + $"[JsonSerializable(typeof({typeof(TData).Name}))] to the JsonSerializerContext shared by "
                + "the client and the server.",
                exception);
        }
    }

    internal SwrCacheEntry<TData> GetOrCreate<TData>(SwrEncodedKey key, JsonTypeInfo<TData> typeInfo)
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

            var entry = new SwrCacheEntry<TData>(key.Key, typeInfo);

            if (_pending is not null && _pending.Remove(key.CacheKey, out var node))
            {
                entry.Hydrate(node);
            }

            _entries[key.CacheKey] = entry;
            return entry;
        }
    }

    /// <summary>
    /// Takes the values the server rendered this page from. Called once, before any component
    /// binds a key.
    /// </summary>
    internal void SeedFromHydration(JsonObject payload)
    {
        lock (_gate)
        {
            _pending ??= new Dictionary<string, JsonNode?>(StringComparer.Ordinal);

            foreach (var (cacheKey, node) in payload)
            {
                _pending[cacheKey] = node;
            }
        }
    }

    /// <summary>
    /// Serializes every entry that holds a value, for the client to pick up instead of fetching
    /// it again. Errors are not transferred: a key that failed on the server was reset, and the
    /// client fetches it normally.
    /// </summary>
    internal JsonObject Dehydrate()
    {
        var payload = new JsonObject();

        lock (_gate)
        {
            foreach (var (cacheKey, entry) in _entries)
            {
                if (entry.TryDehydrate(out var node))
                {
                    payload[cacheKey] = node;
                }
            }
        }

        return payload;
    }
}
