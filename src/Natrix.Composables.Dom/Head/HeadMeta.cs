using Natrix.Signals;

namespace Natrix.Composables.Dom.Head;

/// <summary>
/// One <c>&lt;meta&gt;</c> tag in a <see cref="HeadInput"/>. Set exactly one of
/// <see cref="Name"/>, <see cref="Property"/> or <see cref="HttpEquiv"/> — it identifies the tag,
/// so calls that use the same one compete for it:
/// <code>
/// new HeadMeta { Name = "description", Content = "Reactive UIs in .NET".ToConstSignal() }
/// new HeadMeta { Property = "og:title", Content = title }
/// </code>
/// </summary>
public sealed class HeadMeta
{
    /// <summary>The <c>name</c> attribute, as in <c>description</c> or <c>robots</c>.</summary>
    public string? Name { get; init; }

    /// <summary>The <c>property</c> attribute Open Graph uses, as in <c>og:title</c>.</summary>
    public string? Property { get; init; }

    /// <summary>The <c>http-equiv</c> attribute, as in <c>refresh</c>.</summary>
    public string? HttpEquiv { get; init; }

    /// <summary>
    /// The <c>content</c> attribute. A value of <c>null</c> contributes nothing, so the tag falls
    /// back to whichever earlier call sets it, or is left out when none does.
    /// </summary>
    public required IReadOnlySignal<string?> Content { get; init; }

    internal HeadMetaKey Key =>
        (Name, Property, HttpEquiv) switch
        {
            ({ } name, null, null) => new HeadMetaKey("name", name),
            (null, { } property, null) => new HeadMetaKey("property", property),
            (null, null, { } httpEquiv) => new HeadMetaKey("http-equiv", httpEquiv),
            _ => throw new InvalidOperationException(
                $"A {nameof(HeadMeta)} sets exactly one of {nameof(Name)}, {nameof(Property)} "
                + $"and {nameof(HttpEquiv)}."),
        };
}

/// <summary>What identifies a meta tag: the attribute that names it, and its value.</summary>
internal readonly record struct HeadMetaKey(string Attribute, string Value)
{
    // The keys unhead lets one call repeat; every other key is one tag per call.
    private static readonly HashSet<string> s_repeatable =
    [
        "theme-color",
        "google-site-verification",
        "author",
        "og:locale:alternate",
        "og:image",
        "og:video",
        "og:audio",
        "article:author",
        "article:tag",
        "book:author",
        "book:tag",
        "twitter:image",
    ];

    /// <summary>
    /// Whether one call can contribute several tags for this key, as with a list of
    /// <c>og:image</c>s. The structured properties that describe them (<c>og:image:width</c>, ...)
    /// repeat along with them.
    /// </summary>
    public bool IsRepeatable =>
        s_repeatable.Contains(Value)
        || Value.StartsWith("og:image:", StringComparison.Ordinal)
        || Value.StartsWith("og:video:", StringComparison.Ordinal)
        || Value.StartsWith("og:audio:", StringComparison.Ordinal)
        || Value.StartsWith("twitter:image:", StringComparison.Ordinal);
}

/// <summary>
/// A meta tag as the head resolves it. <paramref name="Occurrence"/> counts the tags before it
/// with the same key, so a repeated key still identifies each tag.
/// </summary>
internal readonly record struct ResolvedHeadMeta(HeadMetaKey Key, int Occurrence, string Content);
