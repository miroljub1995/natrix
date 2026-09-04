namespace Natrix.Swr;

/// <summary>
/// A key paired with the string the cache files it under. The two travel together because the
/// binding path needs both and must never compute one from a different version of the other: the
/// entry is found by <see cref="CacheKey"/>, while the fetcher is handed <see cref="Key"/> so it
/// can read its parameters back out.
/// </summary>
/// <remarks>
/// Identity is the encoding, not the key — which is what makes this, rather than
/// <see cref="SwrKey"/>, the thing a resource watches for changes. Two keys that differ only in a
/// segment's declared type share an entry, and rebinding between them would cancel a request that
/// the entry they both point at is still running.
/// </remarks>
internal readonly struct SwrEncodedKey(SwrKey key, string cacheKey) : IEquatable<SwrEncodedKey>
{
    public SwrKey Key { get; } = key;

    /// <summary>
    /// Empty for <see cref="SwrKey.None"/>, which is filed nowhere.
    /// </summary>
    public string CacheKey { get; } = cacheKey;

    public bool HasValue => Key.HasValue;

    public bool Equals(SwrEncodedKey other) =>
        string.Equals(CacheKey, other.CacheKey, StringComparison.Ordinal);

    public override bool Equals(object? obj) => obj is SwrEncodedKey other && Equals(other);

    public override int GetHashCode() => StringComparer.Ordinal.GetHashCode(CacheKey);

    public override string ToString() => Key.ToString();
}
