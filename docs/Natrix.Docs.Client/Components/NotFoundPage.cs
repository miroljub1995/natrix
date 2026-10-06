using Natrix.Composables.Dom.Head;
using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Composables.Dom.DomComposables;

namespace Natrix.Docs.Client.Components;

/// <summary>
/// The status code the rendered page should be served with. The server registers one per request
/// and reads it once the tree has mounted; in the browser there is none, and nothing to set.
/// </summary>
/// <remarks>
/// A signal, since <c>&lt;head&gt;</c> mounts before the page that decides it.
/// </remarks>
public sealed class PageStatus
{
    public Signal<int> StatusCode { get; } = new(200);
}

/// <summary>
/// What a path no page claims renders: served as a 404 and kept out of search results, rather than
/// as an empty page that search engines would index as a duplicate.
/// </summary>
public class NotFoundPage : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        if (AppFeatures.Features.Get<PageStatus>() is { } status)
        {
            status.StatusCode.Value = 404;
        }

        Site.UsePageHead("Page not found", "There is no page at this address.");
        UseHead(new HeadInput
        {
            Meta = [new HeadMeta { Name = "robots", Content = "noindex".ToConstSignal() }],
        });

        return
        [
            new H1
            {
                Props = new H1Props
                {
                    Class = "text-4xl font-bold text-gray-900 dark:text-white mb-6".ToConstSignal(),
                },
                Children = [new DomText { Text = "Page not found".ToConstSignal() }],
            },
            new P
            {
                Props = new PProps
                {
                    Class = "mb-6 text-gray-600 dark:text-gray-400".ToConstSignal(),
                },
                Children = [new DomText { Text = "There is no page at this address. It may have moved, or the link may be mistyped.".ToConstSignal() }],
            },
            new RouterLink
            {
                Props = new RouterLinkProps
                {
                    Href = "/",
                    Class = "font-semibold text-indigo-600 dark:text-indigo-400 hover:underline",
                },
                Slots = new RouterLinkSlots
                {
                    Default = () => [new DomText { Text = "Back to the home page".ToConstSignal() }],
                },
            },
        ];
    }
}
