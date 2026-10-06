using Natrix.Signals;

namespace Natrix.Composables.Dom.Head;

/// <summary>
/// What one <see cref="DomComposables.UseHead"/> call contributes to the document head. Every
/// property is optional, so a call states only what it has an opinion about and the rest comes
/// from the other components that called it.
/// </summary>
/// <remarks>
/// Calls stack in the order they were made, and for each property the latest call that sets it
/// wins. A layout's <c>Setup</c> runs before the page it renders, so a page overrides its layout,
/// and when the page unmounts the layout's values are back.
/// </remarks>
public sealed class HeadInput
{
    /// <summary>
    /// The document title. A value of <c>null</c> contributes nothing, so the title falls back to
    /// whichever earlier call sets one — which is how a component gives up the title for a while
    /// without unmounting.
    /// </summary>
    public IReadOnlySignal<string?>? Title { get; init; }

    /// <summary>
    /// Wraps the title that wins, wherever it came from, so a layout can add the site name once
    /// and pages set only their own part:
    /// <code>
    /// TitleTemplate = title =&gt; $"{title} · Natrix"
    /// </code>
    /// Like <see cref="Title"/>, the latest call that sets one wins; a page that wants its title
    /// as it is passes <c>title =&gt; title</c>. Signals read inside it are tracked.
    /// </summary>
    public Func<string, string>? TitleTemplate { get; init; }

    /// <summary>
    /// Meta tags, resolved the way unhead resolves them. For each <c>name</c>, <c>property</c> or
    /// <c>http-equiv</c>, the latest call that gives it content wins, so a page can replace its
    /// layout's <c>description</c> and leave the rest alone. A tag whose content is <c>null</c>
    /// contributes nothing.
    /// </summary>
    /// <remarks>
    /// <para>
    /// A call can repeat the keys that take a list — <c>og:image</c>, <c>og:video</c>,
    /// <c>og:audio</c>, <c>og:locale:alternate</c>, <c>twitter:image</c>, <c>article:tag</c>,
    /// <c>article:author</c>, <c>book:tag</c>, <c>book:author</c>, <c>author</c>,
    /// <c>theme-color</c>, <c>google-site-verification</c>, and the structured properties under the
    /// media ones (<c>og:image:width</c>, ...). The winning call contributes all of its tags for
    /// such a key, replacing an earlier call's set as a whole. For any other key, the call's last
    /// tag counts.
    /// </para>
    /// <para>
    /// Tags are written in the order the winning calls were made and listed them, so structured
    /// properties stay after the <c>og:image</c> they describe.
    /// </para>
    /// </remarks>
    public IReadOnlyList<HeadMeta>? Meta { get; init; }
}
