using System.Text.Json.Nodes;

namespace Natrix.Query.Tests.Tests;

public class QueryKeyTests
{
    [Test]
    public async Task Equal_segments_make_the_same_key()
    {
        QueryKey first = ["todos", 5];
        var second = new QueryKey("todos", 5);

        await Assert.That(second.Hash).IsEqualTo(first.Hash);
        await Assert.That(first == second).IsTrue();
        await Assert.That(second.GetHashCode()).IsEqualTo(first.GetHashCode());
    }

    [Test]
    public async Task How_a_segment_was_built_does_not_matter()
    {
        QueryKey literal = ["todos", 5];
        QueryKey constructed = [JsonValue.Create("todos"), JsonValue.Create(5)];

        await Assert.That(constructed == literal).IsTrue();
        await Assert.That(constructed.Hash).IsEqualTo(literal.Hash);
    }

    [Test]
    public async Task Different_segments_make_different_keys()
    {
        QueryKey todos = ["todos"];
        QueryKey todo = ["todos", 5];
        QueryKey other = ["users", 5];

        await Assert.That(todos == todo).IsFalse();
        await Assert.That(todo == other).IsFalse();
        await Assert.That(todos.Hash).IsNotEqualTo(todo.Hash);
        await Assert.That(todo.Hash).IsNotEqualTo(other.Hash);
    }

    [Test]
    public async Task Numbers_and_strings_are_distinguishable()
    {
        QueryKey number = ["todos", 5];
        QueryKey text = ["todos", "5"];

        await Assert.That(number == text).IsFalse();
        await Assert.That(number.Hash).IsNotEqualTo(text.Hash);
    }

    [Test]
    public async Task Object_segments_are_identified_regardless_of_member_order()
    {
        QueryKey first = ["todos", new JsonObject { ["page"] = 1, ["sort"] = "asc" }];
        QueryKey second = ["todos", new JsonObject { ["sort"] = "asc", ["page"] = 1 }];

        await Assert.That(second == first).IsTrue();

        // The hash has to agree with equality, or the two would address different cache entries.
        await Assert.That(second.Hash).IsEqualTo(first.Hash);
    }

    [Test]
    public async Task Object_segments_with_different_values_are_different_keys()
    {
        QueryKey first = ["todos", new JsonObject { ["page"] = 1 }];
        QueryKey second = ["todos", new JsonObject { ["page"] = 2 }];

        await Assert.That(second == first).IsFalse();
        await Assert.That(second.Hash).IsNotEqualTo(first.Hash);
    }

    [Test]
    public async Task Nulls_and_nested_arrays_are_segments_like_any_other()
    {
        QueryKey key = ["todos", null, new JsonArray(1, 2)];
        QueryKey same = ["todos", null, new JsonArray(1, 2)];
        QueryKey different = ["todos", null, new JsonArray(1, 3)];

        await Assert.That(same == key).IsTrue();
        await Assert.That(different == key).IsFalse();
        await Assert.That(same.Hash).IsEqualTo(key.Hash);
    }

    [Test]
    public async Task Nested_structures_are_compared_all_the_way_down()
    {
        QueryKey key =
        [
            "todos",
            new JsonObject
            {
                ["filter"] = new JsonObject { ["done"] = false },
                ["tags"] = new JsonArray("a", "b"),
            },
        ];

        QueryKey same =
        [
            "todos",
            new JsonObject
            {
                ["tags"] = new JsonArray("a", "b"),
                ["filter"] = new JsonObject { ["done"] = false },
            },
        ];

        QueryKey different =
        [
            "todos",
            new JsonObject
            {
                ["filter"] = new JsonObject { ["done"] = true },
                ["tags"] = new JsonArray("a", "b"),
            },
        ];

        await Assert.That(same == key).IsTrue();
        await Assert.That(different == key).IsFalse();
    }

    [Test]
    public async Task A_prefix_key_partially_matches_longer_keys()
    {
        QueryKey todo = ["todos", 5];

        await Assert.That(todo.PartiallyMatches(["todos"])).IsTrue();
        await Assert.That(todo.PartiallyMatches(["todos", 5])).IsTrue();
        await Assert.That(todo.PartiallyMatches(["todos", 6])).IsFalse();
        await Assert.That(todo.PartiallyMatches(["users"])).IsFalse();
        await Assert.That(todo.PartiallyMatches(["todos", 5, "extra"])).IsFalse();
    }

    [Test]
    public async Task Partial_matching_looks_inside_object_segments()
    {
        QueryKey key = ["todos", new JsonObject { ["page"] = 1, ["sort"] = "asc" }];

        await Assert.That(key.PartiallyMatches(["todos", new JsonObject { ["page"] = 1 }])).IsTrue();
        await Assert.That(key.PartiallyMatches(["todos", new JsonObject { ["page"] = 2 }])).IsFalse();
        await Assert.That(key.PartiallyMatches(["todos", new JsonObject { ["missing"] = 1 }])).IsFalse();
    }

    [Test]
    public async Task Partial_matching_looks_inside_array_segments()
    {
        QueryKey key = ["todos", new JsonArray(1, 2, 3)];

        await Assert.That(key.PartiallyMatches(["todos", new JsonArray(1, 2)])).IsTrue();
        await Assert.That(key.PartiallyMatches(["todos", new JsonArray(2)])).IsFalse();
        await Assert.That(key.PartiallyMatches(["todos", new JsonArray(1, 2, 3, 4)])).IsFalse();
    }

    [Test]
    public async Task A_key_reads_as_the_list_of_segments_it_is()
    {
        QueryKey key = ["todos", 5];

        await Assert.That(key.Count).IsEqualTo(2);
        await Assert.That(key[0]!.GetValue<string>()).IsEqualTo("todos");
        await Assert.That(key[1]!.GetValue<int>()).IsEqualTo(5);
        await Assert.That(string.Join('/', key)).IsEqualTo("todos/5");
    }

    [Test]
    public async Task A_key_is_usable_as_a_dictionary_key()
    {
        var seen = new Dictionary<QueryKey, string>
        {
            [["todos", 1]] = "first",
        };

        await Assert.That(seen[["todos", 1]]).IsEqualTo("first");
        await Assert.That(seen.ContainsKey(["todos", 2])).IsFalse();
    }
}
