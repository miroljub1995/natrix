using System.Buffers;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Natrix.Query;

/// <summary>
/// The identity of a query: an ordered list of JSON values, exactly like the array TanStack
/// Query uses (<c>queryKey: ['todos', 5]</c>).
/// </summary>
/// <remarks>
/// <para>
/// Segments are <see cref="JsonNode"/>s, which is what the JavaScript original's keys are in
/// all but name. Primitives convert implicitly, so the everyday key reads the same as it does
/// there; anything richer is written as a <see cref="JsonObject"/> or <see cref="JsonArray"/>,
/// or produced by your own serializer.
/// </para>
/// <para>
/// Keys are compared with <see cref="JsonNode.DeepEquals"/>, so equal values are one key
/// however they were built, and object member order never affects identity. Cache lookup goes
/// through <see cref="Hash"/>, a canonical rendering that sorts object members for exactly that
/// reason.
/// </para>
/// <para>
/// A key is expected to be immutable once used: mutating a segment afterwards changes what the
/// key means without changing the entry it already addressed, the same hazard any mutable
/// dictionary key carries.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// QueryKey key = ["todos", todoId];
/// QueryKey filtered = ["todos", new JsonObject { ["page"] = 1, ["sort"] = "asc" }];
/// </code>
/// </example>
[CollectionBuilder(typeof(QueryKey), nameof(Create))]
public sealed class QueryKey : IReadOnlyList<JsonNode?>, IEquatable<QueryKey>
{
    private readonly JsonNode?[] _segments;
    private string? _hash;

    public QueryKey(params JsonNode?[] segments)
    {
        ArgumentNullException.ThrowIfNull(segments);
        _segments = segments;
    }

    /// <summary>Collection-expression factory, so <c>QueryKey key = ["todos", id];</c> compiles.</summary>
    public static QueryKey Create(ReadOnlySpan<JsonNode?> segments) => new(segments.ToArray());

    /// <summary>
    /// The canonical rendering used to address the cache: the segments as a JSON array, with
    /// the members of every object sorted by name so that two keys
    /// <see cref="JsonNode.DeepEquals"/> considers equal render identically.
    /// </summary>
    public string Hash => _hash ??= ComputeHash();

    public JsonNode? this[int index] => _segments[index];

    public int Count => _segments.Length;

    public IEnumerator<JsonNode?> GetEnumerator() => ((IEnumerable<JsonNode?>)_segments).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _segments.GetEnumerator();

    /// <summary>
    /// Whether this key is matched by <paramref name="filterKey"/> used as a prefix filter —
    /// the semantics of <c>partialMatchKey</c>: every segment the filter specifies must match
    /// the corresponding one here, while extra segments here are ignored. That is what makes
    /// <c>["todos"]</c> select <c>["todos", 1]</c>.
    /// </summary>
    public bool PartiallyMatches(QueryKey filterKey)
    {
        ArgumentNullException.ThrowIfNull(filterKey);

        if (filterKey.Count > Count)
        {
            return false;
        }

        for (var i = 0; i < filterKey.Count; i++)
        {
            if (!PartiallyMatches(_segments[i], filterKey._segments[i]))
            {
                return false;
            }
        }

        return true;
    }

    public bool Equals(QueryKey? other)
    {
        if (other is null || other._segments.Length != _segments.Length)
        {
            return false;
        }

        for (var i = 0; i < _segments.Length; i++)
        {
            if (!JsonNode.DeepEquals(_segments[i], other._segments[i]))
            {
                return false;
            }
        }

        return true;
    }

    public override bool Equals(object? obj) => Equals(obj as QueryKey);

    public override int GetHashCode() => Hash.GetHashCode(StringComparison.Ordinal);

    public override string ToString() => Hash;

    public static bool operator ==(QueryKey? left, QueryKey? right) =>
        left is null ? right is null : left.Equals(right);

    public static bool operator !=(QueryKey? left, QueryKey? right) => !(left == right);

    /// <summary>
    /// Deep matching that lets a filter name only the parts it cares about: an object need only
    /// carry the members the filter lists, an array need only start with the elements it lists.
    /// Anything else is an ordinary value comparison.
    /// </summary>
    private static bool PartiallyMatches(JsonNode? actual, JsonNode? filter)
    {
        if (JsonNode.DeepEquals(actual, filter))
        {
            return true;
        }

        if (actual is JsonObject actualObject && filter is JsonObject filterObject)
        {
            foreach (var (name, expected) in filterObject)
            {
                if (!actualObject.TryGetPropertyValue(name, out var value) || !PartiallyMatches(value, expected))
                {
                    return false;
                }
            }

            return true;
        }

        if (actual is JsonArray actualArray && filter is JsonArray filterArray)
        {
            if (filterArray.Count > actualArray.Count)
            {
                return false;
            }

            for (var i = 0; i < filterArray.Count; i++)
            {
                if (!PartiallyMatches(actualArray[i], filterArray[i]))
                {
                    return false;
                }
            }

            return true;
        }

        return false;
    }

    private string ComputeHash()
    {
        var buffer = new ArrayBufferWriter<byte>();

        using (var writer = new Utf8JsonWriter(buffer))
        {
            writer.WriteStartArray();

            foreach (var segment in _segments)
            {
                WriteCanonical(writer, segment);
            }

            writer.WriteEndArray();
        }

        return Encoding.UTF8.GetString(buffer.WrittenSpan);
    }

    private static void WriteCanonical(Utf8JsonWriter writer, JsonNode? node)
    {
        switch (node)
        {
            case null:
                writer.WriteNullValue();
                break;

            case JsonObject obj:
                // Sorted, so that two objects with the same members hash identically no matter
                // in which order they were written — the point of TanStack Query's sorted
                // JSON.stringify replacer, and what keeps the hash agreeing with DeepEquals.
                writer.WriteStartObject();
                foreach (var (name, value) in obj.OrderBy(static member => member.Key, StringComparer.Ordinal))
                {
                    writer.WritePropertyName(name);
                    WriteCanonical(writer, value);
                }

                writer.WriteEndObject();
                break;

            case JsonArray array:
                writer.WriteStartArray();
                foreach (var item in array)
                {
                    WriteCanonical(writer, item);
                }

                writer.WriteEndArray();
                break;

            default:
                node.WriteTo(writer);
                break;
        }
    }
}
