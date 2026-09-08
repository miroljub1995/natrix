using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Natrix.Swr.Tests;

/// <summary>
/// The encoding is what the cache files entries under, and what the property names of the
/// hydration payload are — so these are tests about identity, not about formatting. Two keys that
/// should be one entry have to encode alike on both hosts, and two that should be separate have
/// to stay separate whatever the application configured its own serialization to do.
/// </summary>
public class SwrKeyEncodingTests
{
    private static SwrKeyEncoder Encoder(JsonSerializerOptions? application = null) =>
        new(application?.TypeInfoResolver ?? TestJsonContext.Default);

    [Test]
    public async Task Absent_key_encodes_to_nothing()
    {
        await Assert.That(Encoder().Encode(SwrKey.None)).IsEmpty();
    }

    [Test]
    public async Task Segment_boundaries_are_part_of_the_key()
    {
        var encoder = Encoder();

        await Assert.That(encoder.Encode(["ab", "c"])).IsNotEqualTo(encoder.Encode(["abc"]));
        await Assert.That(encoder.Encode(["user:42"])).IsNotEqualTo(encoder.Encode(["user", "42"]));
    }

    [Test]
    public async Task Scalars_need_no_registration_from_the_application()
    {
        // An application registers the shapes it fetches; nobody thinks to register the shape of
        // an id. So the library brings contracts for what keys are made of, and passing no
        // application resolver at all is the sharpest way to say that.
        var encoder = new SwrKeyEncoder(applicationResolver: null);

        await Assert.That(encoder.Encode([new SwrKeySegment(Guid.Empty, typeof(Guid))]))
            .IsEqualTo("""["00000000-0000-0000-0000-000000000000"]""");
        await Assert.That(encoder.Encode([SwrKeySegment.Of("user"), SwrKeySegment.Of(42)]))
            .IsEqualTo("""["user",42]""");
    }

    [Test]
    public async Task An_optional_scalar_needs_no_registration_either()
    {
        // A nullable value type is a distinct type to the serializer, so registering the
        // underlying one does not cover it - and an optional segment is half the reason a key is
        // built from a tuple rather than a string.
        var encoder = new SwrKeyEncoder(applicationResolver: null);

        await Assert.That(encoder.Encode([SwrKeySegment.Of((int?)42)])).IsEqualTo("[42]");
        await Assert.That(encoder.Encode([SwrKeySegment.Of((int?)null)])).IsEqualTo("[null]");
        await Assert.That(encoder.Encode([SwrKeySegment.Of((Guid?)Guid.Empty)]))
            .IsEqualTo("""["00000000-0000-0000-0000-000000000000"]""");

        // Distinct from the string "42", and from the absent key.
        await Assert.That(encoder.Encode([SwrKeySegment.Of((int?)42)]))
            .IsNotEqualTo(encoder.Encode(["42"]));
    }

    [Test]
    public async Task A_segment_type_nothing_describes_is_reported()
    {
        await Assert.That(() => Encoder().Encode([SwrKeySegment.Of(new Unregistered(1))]))
            .Throws<InvalidOperationException>();
    }

    [Test]
    public async Task Segments_that_differ_only_in_declared_type_are_one_key()
    {
        // Which is the reason the cache is keyed by this and not by SwrKey.Equals: the two do
        // land on one entry, so a resource must not rebind between them.
        var encoder = Encoder();

        await Assert.That(encoder.Encode([SwrKeySegment.Of(1)]))
            .IsEqualTo(encoder.Encode([SwrKeySegment.Of(1L)]));
    }

    [Test]
    public async Task Object_properties_are_ordered()
    {
        // System.Text.Json writes a dictionary in insertion order and no option changes that, so
        // without the sort the same filter built in a different order is a second cache entry -
        // fetched again, and never found in the hydration payload the first one wrote.
        var encoder = Encoder();

        var built = new Dictionary<string, int> { ["page"] = 1, ["size"] = 20 };
        var rebuilt = new Dictionary<string, int> { ["size"] = 20, ["page"] = 1 };

        await Assert.That(encoder.Encode([SwrKeySegment.Of(built)]))
            .IsEqualTo(encoder.Encode([SwrKeySegment.Of(rebuilt)]));
    }

    [Test]
    public async Task The_applications_dropped_nulls_do_not_collapse_two_keys()
    {
        // Under WhenWritingNull the application writes {"page":1} for both of these, which would
        // serve one component the other's data.
        var encoder = Encoder(new JsonSerializerOptions
        {
            TypeInfoResolver = TestJsonContext.Default,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        });

        await Assert.That(encoder.Encode([SwrKeySegment.Of(new TestFilter(null, 1))]))
            .IsNotEqualTo(encoder.Encode([SwrKeySegment.Of(new TestFilter("sales", 1))]));
    }

    [Test]
    public async Task The_two_hosts_encode_a_key_the_same_way()
    {
        // The cache keys are the property names of the hydration payload, so a server and a
        // browser that configured their own serialization differently still have to agree. Every
        // difference below is one the application is entitled to make.
        var server = new SwrKeyEncoder(new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            TypeInfoResolver = TestJsonContext.Default,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        }.TypeInfoResolver);

        var client = new SwrKeyEncoder(new JsonSerializerOptions
        {
            TypeInfoResolver = TestJsonContext.Default,
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
            NumberHandling = JsonNumberHandling.WriteAsString,
        }.TypeInfoResolver);

        SwrKey key = [SwrKeySegment.Of("sales & ops"), SwrKeySegment.Of(new TestFilter("sales", 1))];

        await Assert.That(server.Encode(key)).IsEqualTo(client.Encode(key));
    }

    private sealed record Unregistered(int Value);
}
