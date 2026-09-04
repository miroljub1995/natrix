using System.Collections;
using System.Runtime.CompilerServices;

namespace Natrix.Swr;

/// <summary>
/// Identifies a cache entry. A key is an ordered list of typed segments, which is what makes
/// composite keys — <c>("user", id, "posts")</c> — cheap to build from the pieces a component
/// already has, instead of asking callers to concatenate a string and get the escaping right.
///
/// The empty key (<see cref="None"/>, or <c>default</c>) means <em>no key</em>: a resource with
/// no key is paused — it never fetches and reports no data. That is how conditional fetching is
/// expressed, mirroring React SWR's <c>null</c> key:
/// <code>
/// () => userId.Value is { } id ? ("user", id) : null
/// </code>
/// </summary>
/// <remarks>
/// <para>
/// The cache identifies a key by its canonical encoding rather than by <see cref="Equals(SwrKey)"/>
/// — see <see cref="SwrKeyEncoder"/>. The two agree in the direction that matters: keys that
/// compare equal always encode alike, so a resource never keeps a claim on an entry the encoding
/// has moved on from. The converse does not hold, since segments of different types can encode to
/// the same JSON: <c>("user", 1)</c> with an <c>int</c> and with a <c>long</c> compare different
/// and share an entry.
/// </para>
/// <para>
/// Which is why <c>Equals</c> is the cheap comparison and the encoding is the authoritative one:
/// a resource can filter out most non-changes without serializing anything, and only pays for the
/// encoding when the segments really moved.
/// </para>
/// </remarks>
[CollectionBuilder(typeof(SwrKey), nameof(Create))]
public readonly struct SwrKey : IEquatable<SwrKey>, IReadOnlyList<SwrKeySegment>
{
    private readonly SwrKeySegment[]? _segments;

    /// <summary>
    /// The tuple this key was built from, kept so that a typed fetcher can be handed back what it
    /// declared rather than have one rebuilt for it. Null for a key built segment by segment.
    /// </summary>
    private readonly ITuple? _source;

    /// <summary>
    /// The absent key. A resource holding it stays paused.
    /// </summary>
    public static SwrKey None => default;

    public SwrKey(params SwrKeySegment[] segments)
    {
        ArgumentNullException.ThrowIfNull(segments);

        if (segments.Length == 0)
        {
            return;
        }

        _segments = segments.AsSpan().ToArray();
    }

    private SwrKey(ITuple source, SwrKeySegment[] segments)
    {
        _source = source;
        _segments = segments;
    }

    /// <summary>
    /// Builds a key from a tuple, each element carrying the type the call declared for it.
    /// </summary>
    internal static SwrKey FromTuple<TTuple>(TTuple tuple)
        where TTuple : struct, ITuple
    {
        var types = SwrKeyTupleShape<TTuple>.ElementTypes;
        var segments = new SwrKeySegment[types.Length];

        for (var i = 0; i < types.Length; i++)
        {
            segments[i] = new SwrKeySegment(tuple[i], types[i]);
        }

        return new SwrKey(tuple, segments);
    }

    /// <summary>
    /// Collection-expression builder, so a key of strings can be written as <c>["user", id]</c>
    /// wherever a <see cref="SwrKey"/> is expected — the elements convert through
    /// <see cref="SwrKeySegment"/>'s implicit operator.
    /// </summary>
    public static SwrKey Create(ReadOnlySpan<SwrKeySegment> segments) => new(segments.ToArray());

    /// <summary>
    /// <c>false</c> for the empty key, which is the paused state rather than a real cache entry.
    /// </summary>
    public bool HasValue => _segments is not null;

    public int Count => _segments?.Length ?? 0;

    public SwrKeySegment this[int index] =>
        _segments is not null
            ? _segments[index]
            : throw new ArgumentOutOfRangeException(nameof(index));

    /// <summary>
    /// The key as the tuple it was built from, which is how a typed fetcher gets its parameters
    /// back out of the key it was handed.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// The key was not built from a tuple of this shape. A resource is handed the key of the entry
    /// it shares, which another <c>Use</c> call may have created — so this is where a typed
    /// fetcher meets a key some other call built differently, or built segment by segment.
    /// </exception>
    public TTuple Tuple<TTuple>()
        where TTuple : struct, ITuple =>
        _source switch
        {
            TTuple typed => typed,
            null => throw new InvalidOperationException(
                $"Key {this} was not built from a tuple, so it cannot be read as {typeof(TTuple)}. "
                + "The same cache key is in use from both a tuple overload and a SwrKey one."),
            _ => throw new InvalidOperationException(
                $"Key {this} was built from a {_source.GetType()}, but is being read as "
                + $"{typeof(TTuple)}. The same cache key is in use with differently typed segments."),
        };

    /// <summary>
    /// Reads segment <paramref name="index"/> as <typeparamref name="TSegment"/>, which is how an
    /// untyped fetcher gets its parameters back out of the key it was handed.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// The segment holds another type. A resource is handed the key of the entry it shares, which
    /// another <c>Use</c> call may have created — and keys whose segments differ only in type can
    /// encode alike, so this is where that meets a fetcher expecting its own. Reported rather than
    /// left to an <see cref="InvalidCastException"/> from inside the fetcher.
    /// </exception>
    public TSegment Segment<TSegment>(int index)
    {
        var segment = this[index];

        return segment.Value switch
        {
            TSegment typed => typed,
            null when default(TSegment) is null => default!,
            _ => throw new InvalidOperationException(
                $"Key {this} holds a {segment.Type} at index {index}, but it is being read as "
                + $"{typeof(TSegment)}. The same cache key is in use with differently typed segments."),
        };
    }

    /// <summary>
    /// Structural comparison over the segments: same count, same declared types, equal values.
    /// See the remarks on <see cref="SwrKey"/> for how this relates to the encoding the cache
    /// keys entries by.
    /// </summary>
    public bool Equals(SwrKey other)
    {
        if (_segments is not { } segments)
        {
            return other._segments is null;
        }

        if (other._segments is not { } others || segments.Length != others.Length)
        {
            return false;
        }

        for (var i = 0; i < segments.Length; i++)
        {
            if (!segments[i].Equals(others[i]))
            {
                return false;
            }
        }

        return true;
    }

    public override bool Equals(object? obj) => obj is SwrKey other && Equals(other);

    public override int GetHashCode()
    {
        if (_segments is not { } segments)
        {
            return 0;
        }

        var hash = new HashCode();
        foreach (var segment in segments)
        {
            hash.Add(segment);
        }

        return hash.ToHashCode();
    }

    public static bool operator ==(SwrKey left, SwrKey right) => left.Equals(right);

    public static bool operator !=(SwrKey left, SwrKey right) => !left.Equals(right);

    public override string ToString() =>
        _segments is null ? "SwrKey.None" : $"[{string.Join(", ", _segments)}]";

    public IEnumerator<SwrKeySegment> GetEnumerator() =>
        ((IEnumerable<SwrKeySegment>)(_segments ?? [])).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
