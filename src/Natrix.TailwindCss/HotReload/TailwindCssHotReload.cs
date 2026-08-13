using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.Core.HotReload;
using Natrix.JSCore;
using Natrix.StdWeb;

namespace Natrix.TailwindCss;

/// <summary>
/// Pushes a regenerated stylesheet into the document while the app is running under hot reload.
/// </summary>
/// <remarks>
/// The generator collects utility candidates from the string literals of the compilation it runs
/// in, so editing a class name there produces a new <c>GetCss</c> body, which hot reload delivers
/// to the browser as an ordinary method-body delta. Without this, the stylesheet the server wrote
/// into the page stays as it was until the next full reload.
/// </remarks>
public static class TailwindCssHotReload
{
    /// <summary>
    /// Id of the <c>&lt;style&gt;</c> element carrying the generated stylesheet.
    /// </summary>
    /// <remarks>
    /// This is the contract between the server-rendered page and the browser:
    /// <see cref="TailwindCssStyle"/> puts this id on the element, and
    /// <see cref="NatrixHostBuilderTailwindCssExtensions.UseTailwindCssHotReload"/> finds it by it
    /// instead of appending a second copy of the stylesheet. It is a fixed <see cref="Guid"/>, so
    /// an app can name its own elements whatever it likes without ever colliding with this one;
    /// pass an explicit id if you render the element yourself.
    /// </remarks>
    public const string StyleElementId = "6ecef332-32bc-4f94-b434-2eea9de684f6";

    /// <summary>
    /// Starts updating the stylesheet element on every hot reload delta. The subscription lives as
    /// long as the app does.
    /// </summary>
    [SupportedOSPlatform("browser")]
    internal static void Attach(IHotReloadManager manager, Func<string> getCss, string elementId)
    {
        var element = ResolveStyleElement(getCss, elementId);
        var updater = new TailwindCssStyleUpdater(getCss, css => element.TextContent = css);

        // The delta's type list is deliberately ignored. It is null whenever the interop layer
        // resolves nothing, consulting the dependency graph would IL-scan a method whose body is
        // the whole stylesheet as a single string literal, and comparing that string is both
        // cheaper and more reliable than either.
        manager.OnDeltaApplied += _ => updater.Refresh();
    }

    [SupportedOSPlatform("browser")]
    private static Node ResolveStyleElement(Func<string> getCss, string elementId)
    {
        var document = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis).Document;

        if (document.GetElementById(elementId) is { } existing)
        {
            return existing;
        }

        var head = document.Head
            ?? throw new InvalidOperationException("The document has no <head> to append the stylesheet to.");

        var element = document.CreateElement("style");
        element.Id = elementId;

        // Seeded rather than left empty: an element with no stylesheet in it would strip the page
        // of every utility until the first delta arrives.
        element.TextContent = getCss();

        head.AppendChild(element);

        return element;
    }
}
