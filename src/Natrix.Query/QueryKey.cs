using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Natrix.Query;

/// <summary>
/// The identity of a query: an ordered, serializable list of segments, exactly like the
/// array TanStack Query uses (<c>queryKey: ['todos', 5]</c>).
/// </summary>
/// <remarks>
/// <para>
/// Keys are compared through <see cref="Hash"/>, a deterministic textual encoding of the
/// segments. Two keys built from equal segments produce the same hash and therefore address
/// the same cache entry, so the key can be rebuilt from scratch on every render.
/// </para>
/// <para>
/// A segment may be <c>null</c>, a primitive, <see cref="string"/>, <see cref="DateTime"/>,
/// <see cref="DateTimeOffset"/>, <see cref="Guid"/>, an enum, a nested sequence, or a
/// dictionary keyed by string (whose entries are ordered by key before hashing, so member
/// order never affects identity). Anything else is encoded through its
/// <see cref="object.ToString"/>, which makes records and tuples first-class key segments;
/// a type that does not override <c>ToString</c> is rejected instead of silently colliding
/// with every other instance of that type.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// QueryKey key = ["todos", todoId];
/// var otherKey = new QueryKey("todos", new Dictionary&lt;string, object?&gt; { ["page"] = 1 });
/// </code>
/// </example>
[CollectionBuilder(typeof(QueryKey), nameof(Create))]
public sealed class QueryKey : IReadOnlyList<object?>, IEquatable<QueryKey>
{
    private readonly object?[] _segments;
    private string? _hash;

    public QueryKey(params object?[] segments)
    {
        ArgumentNullException.ThrowIfNull(segments);
        _segments = segments;
    }

    /// <summary>Collection-expression factory, so <c>QueryKey key = ["todos", id];</c> compiles.</summary>
    public static QueryKey Create(ReadOnlySpan<object?> segments) => new(segments.ToArray());

    /// <summary>The deterministic encoding used as the cache dictionary key.</summary>
    public string Hash => _hash ??= QueryKeyHasher.Hash(_segments);

    public object? this[int index] => _segments[index];

    public int Count => _segments.Length;

    public IEnumerator<object?> GetEnumerator() => ((IEnumerable<object?>)_segments).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _segments.GetEnumerator();

    /// <summary>
    /// Whether this key is matched by <paramref name="filterKey"/> used as a prefix filter —
    /// the semantics of <c>partialMatchKey</c>: every segment the filter specifies must
    /// deep-match the corresponding segment here, while extra segments here are ignored.
    /// </summary>
    public bool PartiallyMatches(QueryKey filterKey)
    {
        ArgumentNullException.ThrowIfNull(filterKey);
        return QueryKeyHasher.PartialDeepEqual(_segments, filterKey._segments);
    }

    public bool Equals(QueryKey? other) => other is not null && Hash == other.Hash;

    public override bool Equals(object? obj) => Equals(obj as QueryKey);

    public override int GetHashCode() => Hash.GetHashCode(StringComparison.Ordinal);

    public override string ToString() => Hash;

    public static bool operator ==(QueryKey? left, QueryKey? right) =>
        left is null ? right is null : left.Equals(right);

    public static bool operator !=(QueryKey? left, QueryKey? right) => !(left == right);
}

/// <summary>
/// Deterministic encoding and partial matching of query key segments — the C# counterpart of
/// TanStack Query's <c>hashKey</c> (a <c>JSON.stringify</c> with object keys sorted) and
/// <c>partialMatchKey</c>.
/// </summary>
public static class QueryKeyHasher
{
    /// <summary>Encodes segments into the stable string used to address the cache.</summary>
    public static string Hash(IEnumerable<object?> segments)
    {
        ArgumentNullException.ThrowIfNull(segments);

        var builder = new System.Text.StringBuilder();
        WriteSequence(builder, segments);
        return builder.ToString();
    }

    private static void Write(System.Text.StringBuilder builder, object? value)
    {
        switch (value)
        {
            case null:
                builder.Append("null");
                return;
            case bool b:
                builder.Append(b ? "true" : "false");
                return;
            case string s:
                WriteString(builder, s);
                return;
            case char c:
                WriteString(builder, c.ToString());
                return;
            case Enum e:
                WriteString(builder, e.ToString());
                return;
            case Guid g:
                WriteString(builder, g.ToString("D", System.Globalization.CultureInfo.InvariantCulture));
                return;
            case DateTime dt:
                WriteString(builder, dt.ToString("O", System.Globalization.CultureInfo.InvariantCulture));
                return;
            case DateTimeOffset dto:
                WriteString(builder, dto.ToString("O", System.Globalization.CultureInfo.InvariantCulture));
                return;
            case DateOnly d:
                WriteString(builder, d.ToString("O", System.Globalization.CultureInfo.InvariantCulture));
                return;
            case TimeSpan ts:
                WriteString(builder, ts.ToString("c", System.Globalization.CultureInfo.InvariantCulture));
                return;
            case IFormattable formattable when IsNumeric(value):
                builder.Append(formattable.ToString(null, System.Globalization.CultureInfo.InvariantCulture));
                return;
        }

        if (TryGetStringKeyedEntries(value, out var entries))
        {
            WriteObject(builder, entries);
            return;
        }

        if (value is IEnumerable sequence)
        {
            WriteSequence(builder, sequence.Cast<object?>());
            return;
        }

        WriteString(builder, Stringify(value));
    }

    private static void WriteSequence(System.Text.StringBuilder builder, IEnumerable<object?> values)
    {
        builder.Append('[');
        var first = true;
        foreach (var item in values)
        {
            if (!first)
            {
                builder.Append(',');
            }

            first = false;
            Write(builder, item);
        }

        builder.Append(']');
    }

    private static void WriteObject(
        System.Text.StringBuilder builder,
        IEnumerable<KeyValuePair<string, object?>> entries)
    {
        builder.Append('{');
        var first = true;

        // Sorted so that two dictionaries with the same content hash identically no matter
        // in which order their entries were added — the whole point of TanStack's sorted
        // JSON.stringify replacer.
        foreach (var entry in entries.OrderBy(static e => e.Key, StringComparer.Ordinal))
        {
            if (!first)
            {
                builder.Append(',');
            }

            first = false;
            WriteString(builder, entry.Key);
            builder.Append(':');
            Write(builder, entry.Value);
        }

        builder.Append('}');
    }

    private static void WriteString(System.Text.StringBuilder builder, string value)
    {
        builder.Append('"');
        foreach (var c in value)
        {
            switch (c)
            {
                case '"':
                    builder.Append("\\\"");
                    break;
                case '\\':
                    builder.Append("\\\\");
                    break;
                case '\n':
                    builder.Append("\\n");
                    break;
                case '\r':
                    builder.Append("\\r");
                    break;
                case '\t':
                    builder.Append("\\t");
                    break;
                default:
                    builder.Append(c);
                    break;
            }
        }

        builder.Append('"');
    }

    private static string Stringify(object value)
    {
        var text = value.ToString();
        var type = value.GetType();

        // object.ToString() falls back to the type name. A key segment encoded as its type
        // name alone collides with every other instance of that type, which would quietly
        // merge unrelated cache entries — so refuse it instead.
        if (text is null || string.Equals(text, type.ToString(), StringComparison.Ordinal))
        {
            throw new InvalidOperationException(
                $"Query key segment of type '{type}' cannot be hashed: it does not override ToString(), " +
                "so every instance would encode identically and share one cache entry. Use a primitive, " +
                "string, enum, Guid, date, record, tuple, sequence or IReadOnlyDictionary<string, object?> " +
                "as a key segment, or override ToString() on the type.");
        }

        return $"{type.FullName}:{text}";
    }

    private static bool IsNumeric(object value) => value
        is byte or sbyte or short or ushort or int or uint or long or ulong
        or float or double or decimal or nint or nuint;

    private static bool TryGetStringKeyedEntries(
        object value,
        [NotNullWhen(true)] out IEnumerable<KeyValuePair<string, object?>>? entries)
    {
        if (value is IEnumerable<KeyValuePair<string, object?>> typed)
        {
            entries = typed;
            return true;
        }

        if (value is IDictionary dictionary)
        {
            var list = new List<KeyValuePair<string, object?>>(dictionary.Count);
            foreach (DictionaryEntry entry in dictionary)
            {
                list.Add(new KeyValuePair<string, object?>(
                    entry.Key as string ?? entry.Key.ToString() ?? string.Empty,
                    entry.Value));
            }

            entries = list;
            return true;
        }

        entries = null;
        return false;
    }

    /// <summary>
    /// <c>partialDeepEqual</c>: every member <paramref name="filter"/> specifies must be
    /// present and deep-equal in <paramref name="actual"/>. Extra members in
    /// <paramref name="actual"/> are ignored, which is what makes <c>["todos"]</c> match
    /// <c>["todos", 1]</c>.
    /// </summary>
    public static bool PartialDeepEqual(object? actual, object? filter)
    {
        if (Equals(actual, filter))
        {
            return true;
        }

        if (actual is null || filter is null)
        {
            return false;
        }

        if (TryGetStringKeyedEntries(filter, out var filterEntries))
        {
            if (!TryGetStringKeyedEntries(actual, out var actualEntries))
            {
                return false;
            }

            var lookup = new Dictionary<string, object?>(StringComparer.Ordinal);
            foreach (var entry in actualEntries)
            {
                lookup[entry.Key] = entry.Value;
            }

            foreach (var entry in filterEntries)
            {
                if (!lookup.TryGetValue(entry.Key, out var actualValue)
                    || !PartialDeepEqual(actualValue, entry.Value))
                {
                    return false;
                }
            }

            return true;
        }

        if (filter is string || actual is string)
        {
            return false;
        }

        if (filter is IEnumerable filterSequence)
        {
            if (actual is not IEnumerable actualSequence)
            {
                return false;
            }

            var actualItems = actualSequence.Cast<object?>().ToList();
            var index = 0;
            foreach (var filterItem in filterSequence.Cast<object?>())
            {
                if (index >= actualItems.Count || !PartialDeepEqual(actualItems[index], filterItem))
                {
                    return false;
                }

                index++;
            }

            return true;
        }

        return false;
    }
}
