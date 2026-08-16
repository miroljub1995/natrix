namespace Natrix.Query.Tests.Tests;

public class QueryKeyTests
{
    private sealed record Filter(int Page, string Sort);

    [Test]
    public async Task Equal_segments_produce_the_same_hash()
    {
        QueryKey first = ["todos", 5];
        var second = new QueryKey("todos", 5);

        await Assert.That(second.Hash).IsEqualTo(first.Hash);
        await Assert.That(first == second).IsTrue();
    }

    [Test]
    public async Task Different_segments_produce_different_hashes()
    {
        QueryKey todos = ["todos"];
        QueryKey todo = ["todos", 5];
        QueryKey other = ["users", 5];

        await Assert.That(todos.Hash).IsNotEqualTo(todo.Hash);
        await Assert.That(todo.Hash).IsNotEqualTo(other.Hash);
    }

    [Test]
    public async Task Numbers_and_strings_are_distinguishable()
    {
        QueryKey number = ["todos", 5];
        QueryKey text = ["todos", "5"];

        await Assert.That(number.Hash).IsNotEqualTo(text.Hash);
    }

    [Test]
    public async Task Dictionary_segments_hash_independently_of_entry_order()
    {
        QueryKey first = ["todos", new Dictionary<string, object?> { ["page"] = 1, ["sort"] = "asc" }];
        QueryKey second = ["todos", new Dictionary<string, object?> { ["sort"] = "asc", ["page"] = 1 }];

        await Assert.That(second.Hash).IsEqualTo(first.Hash);
    }

    [Test]
    public async Task Records_are_usable_as_segments()
    {
        QueryKey first = ["todos", new Filter(1, "asc")];
        QueryKey second = ["todos", new Filter(1, "asc")];
        QueryKey third = ["todos", new Filter(2, "asc")];

        await Assert.That(second.Hash).IsEqualTo(first.Hash);
        await Assert.That(third.Hash).IsNotEqualTo(first.Hash);
    }

    [Test]
    public async Task A_segment_that_cannot_be_encoded_is_rejected()
    {
        QueryKey key = ["todos", new object()];

        await Assert.That(() => key.Hash).Throws<InvalidOperationException>();
    }

    [Test]
    public async Task Nulls_and_nested_sequences_are_encoded()
    {
        QueryKey key = ["todos", null, new[] { 1, 2 }];
        QueryKey same = ["todos", null, new[] { 1, 2 }];
        QueryKey different = ["todos", null, new[] { 1, 3 }];

        await Assert.That(same.Hash).IsEqualTo(key.Hash);
        await Assert.That(different.Hash).IsNotEqualTo(key.Hash);
    }

    [Test]
    public async Task A_prefix_key_partially_matches_longer_keys()
    {
        QueryKey todo = ["todos", 5];

        await Assert.That(todo.PartiallyMatches(["todos"])).IsTrue();
        await Assert.That(todo.PartiallyMatches(["todos", 5])).IsTrue();
        await Assert.That(todo.PartiallyMatches(["todos", 6])).IsFalse();
        await Assert.That(todo.PartiallyMatches(["users"])).IsFalse();
    }

    [Test]
    public async Task Partial_matching_looks_inside_dictionary_segments()
    {
        QueryKey key = ["todos", new Dictionary<string, object?> { ["page"] = 1, ["sort"] = "asc" }];

        await Assert.That(key.PartiallyMatches(["todos", new Dictionary<string, object?> { ["page"] = 1 }])).IsTrue();
        await Assert.That(key.PartiallyMatches(["todos", new Dictionary<string, object?> { ["page"] = 2 }])).IsFalse();
    }

    [Test]
    public async Task Enumerating_a_key_yields_its_segments()
    {
        QueryKey key = ["todos", 5];

        await Assert.That(key.Count).IsEqualTo(2);
        await Assert.That(key[0]).IsEqualTo("todos");
        await Assert.That(key.ToArray()).IsEquivalentTo(new object?[] { "todos", 5 });
    }
}
