using System.Runtime.InteropServices.JavaScript;
using System.Text;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.JSCore;
using Natrix.StdWeb;

namespace Natrix.Dom.Browser.Tests;

internal static class DomRenderer
{
    private static readonly HashSet<string> s_voidElements =
    [
        "area", "base", "br", "col", "embed", "hr", "img", "input", "link", "meta", "source", "track", "wbr",
    ];

    /// <summary>
    /// Mounts the tree into a detached container, so elements such as <c>base</c> or <c>script</c>
    /// have no effect on the page running the tests.
    /// </summary>
    public static (Element Container, IDisposable Host) Mount(Func<IComponent> root)
    {
        var container = CreateContainer();

        var host = new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .UseRootComponent(root)
            .Build()
            .Mount();

        return (container, host);
    }

    public static Element CreateContainer() =>
        JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis).Document.CreateElement("div");

    /// <summary>
    /// Serialises the container's children the way the server writes them with sorted attributes,
    /// so browser and server output compare directly. Attributes with an empty value are written
    /// bare, as the server writes boolean attributes.
    /// </summary>
    /// <remarks>
    /// Walks <c>childNodes</c> rather than reading <c>innerHTML</c>: a <c>template</c>'s
    /// <c>innerHTML</c> is its content fragment, not the children appended to it.
    /// </remarks>
    public static string Serialize(Node container)
    {
        var sb = new StringBuilder();
        WriteChildren(sb, container, raw: false);
        return sb.ToString();
    }

    /// <summary>
    /// Reads a JS property of <paramref name="element"/> as the CLR value it compares to.
    /// </summary>
    public static object? GetProperty(Element element, string name) =>
        element.JSObject.GetTypeOfProperty(name) switch
        {
            "boolean" => element.JSObject.GetPropertyAsBoolean(name),
            "number" => element.JSObject.GetPropertyAsDouble(name),
            "string" => element.JSObject.GetPropertyAsString(name),
            var type => $"<{type}>",
        };

    private static void WriteChildren(StringBuilder sb, Node parent, bool raw)
    {
        var children = parent.ChildNodes;
        for (uint i = 0; i < children.Length; i++)
        {
            WriteNode(sb, children.Item(i)!, raw);
        }
    }

    private static void WriteNode(StringBuilder sb, Node node, bool raw)
    {
        switch (node.NodeType)
        {
            case Node.TEXT_NODE:
                var text = node.TextContent ?? string.Empty;
                sb.Append(raw ? text : Escape(text, quotes: false));
                break;

            case Node.COMMENT_NODE:
                sb.Append("<!--").Append(node.TextContent).Append("-->");
                break;

            case Node.ELEMENT_NODE:
                var element = JSObjectProxyFactory.GetProxy<Element>(node.JSObject);
                var tag = element.LocalName;

                sb.Append('<').Append(tag);
                var attributes = element.Attributes;
                var pairs = new List<(string Name, string Value)>();
                for (uint i = 0; i < attributes.Length; i++)
                {
                    var attribute = attributes.Item(i)!;
                    pairs.Add((attribute.Name, attribute.Value));
                }

                foreach (var (name, value) in pairs.OrderBy(static p => p.Name, StringComparer.Ordinal))
                {
                    sb.Append(' ').Append(name);
                    if (value.Length > 0)
                    {
                        sb.Append("=\"").Append(Escape(value, quotes: true)).Append('"');
                    }
                }

                sb.Append('>');

                if (!s_voidElements.Contains(tag))
                {
                    WriteChildren(sb, element, raw: tag is "script" or "style");
                    sb.Append("</").Append(tag).Append('>');
                }

                break;
        }
    }

    private static string Escape(string value, bool quotes)
    {
        var escaped = value.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
        return quotes ? escaped.Replace("\"", "&quot;") : escaped;
    }
}
