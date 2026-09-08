using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;

namespace Natrix.Browser.TestHost.Bridge;

/// <summary>
/// Matches test node paths against a Microsoft.Testing.Platform tree-node filter
/// (<c>/Assembly/Namespace/Type/Method</c>). The platform's own matcher cannot be
/// constructed from outside, so this covers the subset the bridge deals in:
/// <c>*</c> wildcards, <c>(a|b)</c> alternation and <c>\</c> escapes. Property
/// conditions in <c>[...]</c> are ignored, and a filter with fewer segments than
/// the path matches the remaining segments as wildcards.
/// </summary>
[UnsupportedOSPlatform("browser")]
internal sealed class TreeNodeFilterMatcher
{
    private readonly Regex[] _segments;

    public TreeNodeFilterMatcher(string filter)
    {
        _segments = SplitSegments(filter).Select(ToRegex).ToArray();
    }

    public bool Matches(params string?[] pathSegments)
    {
        for (var i = 0; i < _segments.Length && i < pathSegments.Length; i++)
        {
            if (!_segments[i].IsMatch(pathSegments[i] ?? string.Empty))
            {
                return false;
            }
        }

        return true;
    }

    private static List<string> SplitSegments(string filter)
    {
        var segments = new List<string>();
        var current = new StringBuilder();
        var depth = 0;

        for (var i = 0; i < filter.Length; i++)
        {
            var character = filter[i];
            switch (character)
            {
                case '\\' when i + 1 < filter.Length:
                    current.Append(character).Append(filter[++i]);
                    break;
                case '(' or '[':
                    depth++;
                    current.Append(character);
                    break;
                case ')' or ']':
                    depth--;
                    current.Append(character);
                    break;
                case '/' when depth == 0:
                    if (current.Length > 0 || segments.Count > 0)
                    {
                        segments.Add(current.ToString());
                    }

                    current.Clear();
                    break;
                default:
                    current.Append(character);
                    break;
            }
        }

        segments.Add(current.ToString());
        return segments;
    }

    private static Regex ToRegex(string segment)
    {
        var pattern = new StringBuilder("^");

        for (var i = 0; i < segment.Length; i++)
        {
            var character = segment[i];
            switch (character)
            {
                case '\\' when i + 1 < segment.Length:
                    pattern.Append(Regex.Escape(segment[++i].ToString()));
                    break;
                case '*':
                    pattern.Append(".*");
                    break;
                case '(':
                    pattern.Append("(?:");
                    break;
                case ')' or '|':
                    pattern.Append(character);
                    break;
                case '[':
                    var close = segment.IndexOf(']', i);
                    i = close < 0 ? segment.Length : close;
                    break;
                default:
                    pattern.Append(Regex.Escape(character.ToString()));
                    break;
            }
        }

        return new Regex(pattern.Append('$').ToString(), RegexOptions.CultureInvariant);
    }
}
