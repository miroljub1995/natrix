using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Natrix.Swr;

/// <summary>
/// Turns a <see cref="SwrKey"/> into the string the cache files it under, by writing its segments
/// as a JSON array.
/// </summary>
/// <remarks>
/// <para>
/// <b>Why not the application's <see cref="JsonSerializerOptions"/>.</b> A serializer guarantees
/// that a value survives a round trip under a given configuration — not that two values encode
/// alike exactly when they are equal, which is the opposite property and the one an identity
/// needs. Left to the application's options, <c>DefaultIgnoreCondition</c> drops a null segment
/// and makes two different keys collide; a <c>PropertyNamingPolicy</c> or <c>Encoder</c> that
/// differs between the server and the browser produces two spellings of the same key, so the
/// hydration payload the server wrote is never found; and <c>NumberHandling</c> can write a
/// number as a string.
/// </para>
/// <para>
/// So this takes the one thing from the application that it must share — the resolver, which is
/// where the contracts for its own types live — and fixes everything about the formatting itself.
/// Object properties are sorted on top of that, because <c>System.Text.Json</c> writes a
/// dictionary in insertion order and no option changes that; without the sort, the same filter
/// built in a different order is a different cache entry.
/// </para>
/// <para>
/// What remains outside its reach is a number's own text: <c>1.00m</c> and <c>1m</c> are equal
/// decimals that encode differently, so they are two entries. Segments that fine-grained are not
/// what keys are made of, and normalizing them means reformatting every number in the DOM.
/// </para>
/// </remarks>
internal sealed class SwrKeyEncoder
{
    /// <summary>
    /// Fixed on every axis that could make the same key encode two ways. Only the resolver is
    /// borrowed from the application, and the library's own contracts go in front of it so that
    /// an ordinary segment — a string, a number, a <see cref="Guid"/> — encodes the same whatever
    /// the application registered.
    /// </summary>
    private readonly JsonSerializerOptions _options;

    /// <summary>
    /// Writing is separate from serializing: by this point the DOM holds literal property names,
    /// so only escaping and indentation are still in play.
    /// </summary>
    private static readonly JsonSerializerOptions WriterOptions = new()
    {
        Encoder = JavaScriptEncoder.Default,
        WriteIndented = false,
    };

    internal SwrKeyEncoder(IJsonTypeInfoResolver? applicationResolver)
    {
        _options = new JsonSerializerOptions
        {
            TypeInfoResolver = applicationResolver is null
                ? SwrKeyJsonContext.Default
                : JsonTypeInfoResolver.Combine(SwrKeyJsonContext.Default, applicationResolver),
            DefaultIgnoreCondition = JsonIgnoreCondition.Never,
            PropertyNamingPolicy = null,
            NumberHandling = JsonNumberHandling.Strict,
            Encoder = JavaScriptEncoder.Default,
            WriteIndented = false,
        };
    }

    /// <summary>
    /// Resolves the contract a segment of <paramref name="type"/> encodes under, so a type the
    /// application never registered is reported by the <c>Use</c> call that named it rather than
    /// from inside the effect that binds the key.
    /// </summary>
    /// <exception cref="InvalidOperationException">Nothing describes <paramref name="type"/>.</exception>
    internal JsonTypeInfo GetSegmentTypeInfo(Type type)
    {
        try
        {
            return _options.GetTypeInfo(type);
        }
        catch (Exception exception) when (exception is InvalidOperationException or NotSupportedException)
        {
            throw new InvalidOperationException(
                $"A key segment of type {type} cannot be encoded: the serializer options in use have no "
                + $"metadata for it. Add [JsonSerializable(typeof({type.Name}))] to the JsonSerializerContext "
                + "shared by the client and the server, or use a segment type the library covers "
                + "(the primitives, Guid, the date and time types, and Uri).",
                exception);
        }
    }

    /// <summary>
    /// The cache key for <paramref name="key"/>. Empty for <see cref="SwrKey.None"/>, which is
    /// never filed in the cache at all.
    /// </summary>
    internal string Encode(SwrKey key)
    {
        if (!key.HasValue)
        {
            return string.Empty;
        }

        var array = new JsonArray();
        foreach (var segment in key)
        {
            array.Add(Canonicalize(
                JsonSerializer.SerializeToNode(segment.Value, GetSegmentTypeInfo(segment.Type))));
        }

        return array.ToJsonString(WriterOptions);
    }

    /// <summary>
    /// Rebuilds a node with every object's properties in ordinal order, so that the order they
    /// were written in — which for a dictionary is the order they were inserted in — stops being
    /// part of the key's identity.
    /// </summary>
    private static JsonNode? Canonicalize(JsonNode? node)
    {
        switch (node)
        {
            case JsonObject obj:
            {
                var ordered = new JsonObject();

                // Detached first: a node belongs to one parent, so the children have to leave the
                // object being read before they can be added to the one being built.
                foreach (var (name, child) in obj.ToArray().OrderBy(property => property.Key, StringComparer.Ordinal))
                {
                    obj.Remove(name);
                    ordered[name] = Canonicalize(child);
                }

                return ordered;
            }

            case JsonArray array:
            {
                var items = array.ToArray();
                array.Clear();

                // Order is meaningful in an array, so only the elements are rewritten.
                return new JsonArray([.. items.Select(Canonicalize)]);
            }

            default:
                return node;
        }
    }
}

/// <summary>
/// Contracts for the types keys are actually made of, so that an ordinary key costs the
/// application no registrations at all — and so that a segment of one of them encodes identically
/// on both sides of the hydration boundary no matter what either host configured.
/// </summary>
/// <remarks>
/// Each value type appears twice, because a nullable one is a distinct type to the serializer and
/// resolves from its underlying registration no more than any other generic instantiation does.
/// Absent them, an optional segment — which is half the reason a key is built from a tuple rather
/// than a string — reports its own type as unsupported.
/// </remarks>
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(bool))]
[JsonSerializable(typeof(char))]
[JsonSerializable(typeof(byte))]
[JsonSerializable(typeof(sbyte))]
[JsonSerializable(typeof(short))]
[JsonSerializable(typeof(ushort))]
[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(uint))]
[JsonSerializable(typeof(long))]
[JsonSerializable(typeof(ulong))]
[JsonSerializable(typeof(float))]
[JsonSerializable(typeof(double))]
[JsonSerializable(typeof(decimal))]
[JsonSerializable(typeof(Guid))]
[JsonSerializable(typeof(DateTime))]
[JsonSerializable(typeof(DateTimeOffset))]
[JsonSerializable(typeof(DateOnly))]
[JsonSerializable(typeof(TimeOnly))]
[JsonSerializable(typeof(TimeSpan))]
[JsonSerializable(typeof(Uri))]
[JsonSerializable(typeof(bool?))]
[JsonSerializable(typeof(char?))]
[JsonSerializable(typeof(byte?))]
[JsonSerializable(typeof(sbyte?))]
[JsonSerializable(typeof(short?))]
[JsonSerializable(typeof(ushort?))]
[JsonSerializable(typeof(int?))]
[JsonSerializable(typeof(uint?))]
[JsonSerializable(typeof(long?))]
[JsonSerializable(typeof(ulong?))]
[JsonSerializable(typeof(float?))]
[JsonSerializable(typeof(double?))]
[JsonSerializable(typeof(decimal?))]
[JsonSerializable(typeof(Guid?))]
[JsonSerializable(typeof(DateTime?))]
[JsonSerializable(typeof(DateTimeOffset?))]
[JsonSerializable(typeof(DateOnly?))]
[JsonSerializable(typeof(TimeOnly?))]
[JsonSerializable(typeof(TimeSpan?))]
internal sealed partial class SwrKeyJsonContext : JsonSerializerContext;
