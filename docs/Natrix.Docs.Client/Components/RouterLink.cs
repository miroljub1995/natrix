using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.Features.Routing;
using Natrix.Dom.Components;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Docs.Client.Components;

public class RouterLinkProps
{
    public required string Href { get; init; }
    public required string Class { get; init; }
}

public class RouterLinkSlots
{
    public required Func<IComponent[]> Default { get; init; }
}

/// <summary>
/// A real <c>&lt;a href&gt;</c> - so crawlers and no-JavaScript visitors can follow it - that
/// navigates in place once the client has hydrated.
/// </summary>
public class RouterLink : BaseComponent<RouterLinkProps, NoEvents, RouterLinkSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var navigation = AppFeatures.Features.GetRequired<INavigationFeature>();

        return
        [
            new A
            {
                Props = new AProps
                {
                    Href = Props.Href.ToConstSignal(),
                    Class = Props.Class.ToConstSignal(),
                },
                Events = new AEvents
                {
                    OnClick = (e) =>
                    {
                        if (!OperatingSystem.IsBrowser()) return;
                        e.PreventDefault();
                        navigation.PushAsync(Props.Href);
                        ScrollToTop();
                    },
                },
                Children = Slots?.Default() ?? [],
            },
        ];
    }

    /// <summary>
    /// Starts a page navigated to in place at the top, as it would on a full load. Through
    /// scrollTop rather than scrollTo(): the binding follows the spec in expecting a promise back,
    /// and browsers still return undefined.
    /// </summary>
    [SupportedOSPlatform("browser")]
    internal static void ScrollToTop()
    {
        var scrolling = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis).Document.ScrollingElement;
        if (scrolling is not null)
        {
            scrolling.ScrollTop = 0;
        }
    }
}
