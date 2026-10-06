using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.Core;
using Natrix.Core.Features;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Composables.Dom.Head;

/// <summary>
/// Gives an application a head for <see cref="DomComposables.UseHead"/> to contribute to. Pick
/// by what the host renders into, not by where it runs: a server render executed in the browser
/// still writes a page, and still wants <see cref="UseServerHead"/>.
/// </summary>
public static class NatrixHostBuilderHeadExtensions
{
    /// <summary>
    /// For a host that renders the page as markup. The head is written by
    /// <see cref="HeadTags"/>, which the page places inside its <c>&lt;head&gt;</c>.
    /// </summary>
    public static NatrixHostBuilder UseServerHead(this NatrixHostBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        return builder.Use(features => Publish(features));
    }

    /// <summary>
    /// For a host that mounts into the live document. Keeps <c>document.title</c> in step with
    /// the title the mounted components resolve to.
    /// </summary>
    /// <remarks>
    /// The document's own title is the fallback: it is shown while no component sets one, and
    /// put back when the host is disposed. On a page the server rendered, that is the title the
    /// server wrote, so hydrating changes nothing the visitor can see.
    /// </remarks>
    [SupportedOSPlatform("browser")]
    public static NatrixHostBuilder UseClientHead(this NatrixHostBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        return builder.Use(features =>
        {
            var manager = Publish(features);
            var document = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis).Document;
            var fallback = document.Title;

            // Mounted under the host's scope, so both are disposed with it.
            new Effect(_ => document.Title = manager.Title.Value ?? fallback);
            new Effect(onCleanup => onCleanup(() => document.Title = fallback));
        });
    }

    private static HeadManager Publish(IFeatureCollection features)
    {
        if (features.Get<HeadManager>() is not null)
        {
            throw new InvalidOperationException(
                "The head is already managed: register UseServerHead() or UseClientHead() once, "
                + "for the host the application renders on.");
        }

        var manager = new HeadManager();
        features.Set(manager);
        return manager;
    }
}
