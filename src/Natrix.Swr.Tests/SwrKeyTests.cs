namespace Natrix.Swr.Tests;

public class SwrKeyTests
{
    [Test]
    public async Task None_has_no_value()
    {
        await Assert.That(SwrKey.None.HasValue).IsFalse();
        await Assert.That(SwrKey.None.Count).IsEqualTo(0);
        await Assert.That(SwrKey.None).IsEqualTo(default(SwrKey));
    }

    [Test]
    public async Task Empty_segments_are_the_absent_key()
    {
        var key = new SwrKey();

        await Assert.That(key.HasValue).IsFalse();
        await Assert.That(key).IsEqualTo(SwrKey.None);
    }

    [Test]
    public async Task Exposes_segments_in_order()
    {
        var key = new SwrKey("user", "42", "posts");

        await Assert.That(key.HasValue).IsTrue();
        await Assert.That(key.Count).IsEqualTo(3);
        await Assert.That(key[0]).IsEqualTo("user");
        await Assert.That(key[2]).IsEqualTo("posts");
        await Assert.That(key.ToArray()).IsEquivalentTo(new[] { "user", "42", "posts" });
    }

    [Test]
    public async Task Equal_segments_produce_equal_keys()
    {
        var a = new SwrKey("user", "42");
        var b = new SwrKey("user", "42");

        await Assert.That(a).IsEqualTo(b);
        await Assert.That(a == b).IsTrue();
        await Assert.That(a.GetHashCode()).IsEqualTo(b.GetHashCode());
    }

    [Test]
    public async Task Segment_boundaries_are_part_of_the_key()
    {
        var split = new SwrKey("ab", "c");
        var joined = new SwrKey("abc");

        await Assert.That(split).IsNotEqualTo(joined);
        await Assert.That(split != joined).IsTrue();
    }

    [Test]
    public async Task Separators_inside_a_segment_cannot_forge_another_key()
    {
        var forged = new SwrKey("user:42");
        var real = new SwrKey("user", "42");

        await Assert.That(forged).IsNotEqualTo(real);
    }

    [Test]
    public async Task Builds_from_a_collection_expression()
    {
        SwrKey key = ["user", "42"];

        await Assert.That(key).IsEqualTo(new SwrKey("user", "42"));
    }

    [Test]
    public async Task Empty_collection_expression_is_the_absent_key()
    {
        SwrKey key = [];

        await Assert.That(key.HasValue).IsFalse();
    }

    [Test]
    public async Task Null_segment_is_rejected()
    {
        await Assert.That(() => new SwrKey("user", null!)).Throws<ArgumentException>();
    }

    [Test]
    public async Task ToString_is_readable()
    {
        await Assert.That(new SwrKey("user", "42").ToString()).IsEqualTo("[user, 42]");
        await Assert.That(SwrKey.None.ToString()).IsEqualTo("SwrKey.None");
    }
}
