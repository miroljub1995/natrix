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

    private static (string? Namespace, string? TypeName) SplitType(string? typeFullName)
    {
        if (string.IsNullOrEmpty(typeFullName))
        {
            return (null, null);
        }

        var nestedStart = typeFullName.IndexOf('+');
        var searchEnd = nestedStart < 0 ? typeFullName.Length : nestedStart;
        var lastDot = typeFullName.LastIndexOf('.', searchEnd - 1);

        return lastDot < 0
            ? (null, typeFullName)
            : (typeFullName[..lastDot], typeFullName[(lastDot + 1)..]);
    }

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

        var parameters = methodSignature[(parenthesis + 1)..].TrimEnd(')');
        return (methodSignature[..parenthesis], parameters.Length == 0 ? [] : parameters.Split(','));
    }
}
