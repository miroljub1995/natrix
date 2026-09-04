using System.Text;
using Natrix.Browser.TestHost.Protocol;
using System.Runtime.Versioning;

namespace Natrix.Browser.TestHost.Bridge;

/// <summary>
/// Builds a Microsoft.Testing.Platform tree-node filter
/// (<c>/Assembly/Namespace/Class/Method</c>) that covers a set of tests. Each
/// segment is an alternation of the distinct values, so the result is a superset
/// when the tests span several classes.
/// </summary>
[UnsupportedOSPlatform("browser")]
internal static class TreeNodeFilterBuilder
{
    private const string SpecialCharacters = "()[]&|/*\\!";

    public static string Build(IReadOnlyCollection<TestEvent> tests) =>
        "/*" +
        Segment(tests.Select(t => t.Namespace)) +
        Segment(tests.Select(t => t.TypeName)) +
        Segment(tests.Select(t => t.MethodName));

    private static string Segment(IEnumerable<string?> values)
    {
        var distinct = values.Select(v => string.IsNullOrEmpty(v) ? "*" : Escape(v)).Distinct().ToArray();
        return "/" + (distinct.Length == 1 ? distinct[0] : "(" + string.Join('|', distinct) + ")");
    }

    private static string Escape(string value)
    {
        var escaped = new StringBuilder(value.Length);
        foreach (var character in value)
        {
            if (SpecialCharacters.Contains(character))
            {
                escaped.Append('\\');
            }

            escaped.Append(character);
        }

        return escaped.ToString();
    }
}
