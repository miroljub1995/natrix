using Natrix.Composables.Dom.Head;
using Natrix.Docs.Client.Components;
using Natrix.Signals;
using static Natrix.Composables.Dom.DomComposables;

namespace Natrix.Docs.Client;

/// <summary>
/// What the head of every page, and the server's <c>robots.txt</c> and <c>sitemap.xml</c>, say
/// about the site.
/// </summary>
public static class Site
{
    public const string Name = "Natrix";

    /// <summary>The published origin, which canonical and Open Graph URLs are absolute against.</summary>
    public const string Origin = "https://natrix.wiki";

    public const string Description =
        "Natrix is an open-source .NET framework for reactive web UIs in C#, running on WebAssembly "
        + "with server-side rendering and fine-grained signals.";

    /// <summary>The image link previews show, 1200×630 as Open Graph and X recommend.</summary>
    public static string SocialImageUrl => Origin + WwwRoot.Assets_Og_Image_Png;

    public const string SocialImageAlt = "Natrix — reactive web UIs, written in C#.";

    public const string GitHubUrl = "https://github.com/miroljub1995/natrix";

    /// <summary>Every page there is: the home page, and the docs as the sidebar lists them.</summary>
    public static IEnumerable<string> Paths =>
        NavItems.Groups.SelectMany(group => group.Items).Select(item => item.Href).Prepend("/");

    /// <summary>
    /// The one URL a page is known by: on <see cref="Origin"/>, without a trailing slash or query.
    /// </summary>
    public static string CanonicalUrl(string path)
    {
        var trimmed = path.TrimEnd('/');
        return Origin + (trimmed.Length == 0 ? "/" : trimmed);
    }

    /// <summary>
    /// Sets a page's title and description, and the Open Graph versions link previews read. Call
    /// from the page's <c>Setup</c>.
    /// </summary>
    /// <param name="description">
    /// What search results show under the title, so best kept to about 155 characters.
    /// </param>
    public static void UsePageHead(IReadOnlySignal<string> title, IReadOnlySignal<string> description) =>
        UseHead(new HeadInput
        {
            Title = title,
            Meta =
            [
                new HeadMeta { Name = "description", Content = description },
                new HeadMeta { Property = "og:title", Content = title },
                new HeadMeta { Property = "og:description", Content = description },
            ],
        });

    public static void UsePageHead(string title, string description) =>
        UsePageHead(title.ToConstSignal(), description.ToConstSignal());
}
