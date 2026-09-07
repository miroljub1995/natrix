using System.Runtime.Versioning;
using Natrix.Browser.TestHost.Protocol;
using Natrix.Browser.TestHost.ServerMode;

namespace Natrix.Browser.TestHost.Bridge;

/// <summary>
/// Discovers tests without a browser by running this same assembly on the host in
/// engine mode, in the platform's server mode, and asking it the way an IDE would.
/// Works for any framework built on Microsoft.Testing.Platform.
/// </summary>
[UnsupportedOSPlatform("browser")]
internal static class EngineDiscovery
{
    public static async Task<List<TestEvent>> DiscoverAsync(Action<string> log, CancellationToken cancellationToken)
    {
        var environment = new Dictionary<string, string?>
        {
            [BrowserTestHost.ModeVariable] = BrowserTestHost.EngineMode,
        };

        HostPaths.EnsureDotnetOnPath();
        var nodes = await ServerModeTestApplication.DiscoverAsync(HostPaths.EntryAssemblyPath, environment, log, cancellationToken);

        return nodes
            .Where(node => node.NodeType is null or "action")
            .Select(ToTestEvent)
            .ToList();
    }

    private static TestEvent ToTestEvent(TestNodeInfo node)
    {
        // "Namespace.Type" and "Method(Param1,Param2)" on the wire; the tree-node filter
        // and the host's method identity want them apart.
        var (ns, typeName) = SplitType(node.TypeFullName);
        var (methodName, parameterTypes) = SplitMethod(node.MethodSignature);

        return new TestEvent
        {
            Uid = node.Uid,
            ParentUid = node.ParentUid,
            DisplayName = node.DisplayName,
            State = TestStates.Discovered,

            Namespace = ns,
            TypeName = typeName,
            MethodName = methodName,
            MethodArity = node.MethodArity,
            ParameterTypeFullNames = parameterTypes,

            FilePath = node.FilePath,
            StartLine = node.LineStart,
            EndLine = node.LineEnd,
        };
    }

    /// <summary>
    /// "Namespace.Type", possibly "Namespace.Outer+Nested", and for classes with
    /// class-level arguments "Namespace.Type(1.5, \"x\")". The argument list is dropped
    /// first so the dots inside it cannot be mistaken for namespace separators.
    /// </summary>
    private static (string? Namespace, string? TypeName) SplitType(string? typeFullName)
    {
        if (string.IsNullOrEmpty(typeFullName))
        {
            return (null, null);
        }

        var argumentsStart = typeFullName.IndexOf('(');
        var name = argumentsStart < 0 ? typeFullName : typeFullName[..argumentsStart];

        var nestedStart = name.IndexOf('+');
        var searchEnd = nestedStart < 0 ? name.Length : nestedStart;
        var lastDot = searchEnd == 0 ? -1 : name.LastIndexOf('.', searchEnd - 1);

        return lastDot < 0
            ? (null, name)
            : (name[..lastDot], name[(lastDot + 1)..]);
    }

    /// <summary>
    /// "Method" or "Method(Type1,Type2)". Parameter types can themselves contain commas
    /// and brackets (generic instantiations, multi-dimensional arrays), so the list is
    /// split only at nesting depth zero.
    /// </summary>
    private static (string? MethodName, string[]? ParameterTypes) SplitMethod(string? methodSignature)
    {
        if (string.IsNullOrEmpty(methodSignature))
        {
            return (null, null);
        }

        var parenthesis = methodSignature.IndexOf('(');
        if (parenthesis < 0)
        {
            return (methodSignature, []);
        }

        var end = methodSignature.LastIndexOf(')');
        var list = methodSignature[(parenthesis + 1)..(end > parenthesis ? end : methodSignature.Length)];
        return (methodSignature[..parenthesis], SplitTopLevel(list));
    }

    private static string[] SplitTopLevel(string list)
    {
        if (list.Length == 0)
        {
            return [];
        }

        var parts = new List<string>();
        var depth = 0;
        var start = 0;
        for (var i = 0; i < list.Length; i++)
        {
            switch (list[i])
            {
                case '<' or '[' or '(':
                    depth++;
                    break;
                case '>' or ']' or ')':
                    depth--;
                    break;
                case ',' when depth == 0:
                    parts.Add(list[start..i].Trim());
                    start = i + 1;
                    break;
            }
        }

        parts.Add(list[start..].Trim());
        return parts.ToArray();
    }
}
