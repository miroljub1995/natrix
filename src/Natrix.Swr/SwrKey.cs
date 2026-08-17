using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace Natrix.Swr;

/// <summary>
/// Identifies a cache entry. A key is an ordered list of string segments, which is what makes
/// composite keys — <c>["user", id, "posts"]</c> — cheap to build from the pieces a component
/// already has, instead of asking callers to concatenate a string and get the escaping right.
///
/// The empty key (<see cref="None"/>, or <c>default</c>) means <em>no key</em>: a resource with
/// no key is paused — it never fetches and reports no data. That is how conditional fetching is
/// expressed, mirroring React SWR's <c>null</c> key:
/// <code>
/// () => userId.Value is { } id ? ["user", id] : SwrKey.None
/// </code>
/// </summary>
/// <remarks>
/// Keys are compared and cached by an injective encoding of their segments (each segment is
/// written length-prefixed), so <c>["ab", "c"]</c> and <c>["abc"]</c> are different keys and no
/// separator can be smuggled in through a segment value.
/// </remarks>
[CollectionBuilder(typeof(SwrKey), nameof(Create))]
public readonly struct SwrKey : IEquatable<SwrKey>, IReadOnlyList<string>
{
    private readonly string[]? _segments;
    private readonly string? _cacheKey;

    /// <summary>
    /// The absent key. A resource holding it stays paused.
    /// </summary>
    public static SwrKey None => default;

    public SwrKey(params string[] segments)
    {
        ArgumentNullException.ThrowIfNull(segments);

        if (segments.Length == 0)
        {
            return;
        }

        var copy = new string[segments.Length];
        for (var i = 0; i < segments.Length; i++)
        {
            copy[i] = segments[i]
                ?? throw new ArgumentException($"Key segment at index {i} is null.", nameof(segments));
        }

        _segments = copy;
        _cacheKey = Encode(copy);
    }

    /// <summary>
    /// Collection-expression builder, so a key can be written as <c>["user", id]</c> wherever a
    /// <see cref="SwrKey"/> is expected.
    /// </summary>
    public static SwrKey Create(ReadOnlySpan<string> segments) => new(segments.ToArray());

    /// <summary>
    /// <c>false</c> for the empty key, which is the paused state rather than a real cache entry.
    /// </summary>
    public bool HasValue => _segments is not null;

    public int Count => _segments?.Length ?? 0;

    public string this[int index] =>
        _segments is not null
            ? _segments[index]
            : throw new ArgumentOutOfRangeException(nameof(index));

    /// <summary>
    /// The injective encoding used as the cache dictionary key. Empty for <see cref="None"/>.
    /// </summary>
    internal string CacheKey => _cacheKey ?? string.Empty;

    private static string Encode(string[] segments)
    {
        var builder = new StringBuilder();
        foreach (var segment in segments)
        {
            builder.Append(segment.Length).Append(':').Append(segment);
        }

        return builder.ToString();
    }

    public bool Equals(SwrKey other) => string.Equals(CacheKey, other.CacheKey, StringComparison.Ordinal);

    public override bool Equals(object? obj) => obj is SwrKey other && Equals(other);

    public override int GetHashCode() => StringComparer.Ordinal.GetHashCode(CacheKey);

    public static bool operator ==(SwrKey left, SwrKey right) => left.Equals(right);

    public static bool operator !=(SwrKey left, SwrKey right) => !left.Equals(right);

    public override string ToString() =>
        _segments is null ? "SwrKey.None" : $"[{string.Join(", ", _segments)}]";

    public IEnumerator<string> GetEnumerator() =>
        ((IEnumerable<string>)(_segments ?? [])).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
