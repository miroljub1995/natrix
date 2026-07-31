namespace Natrix.Ssr.Abstractions.Features.RawText;

/// <summary>
/// SSR-only feature describing whether the surrounding element is an HTML
/// <em>raw text</em> element (<c>script</c>, <c>style</c>). Inside those elements the
/// HTML parser does not decode character references, so their text content must be
/// written verbatim instead of being escaped.
/// </summary>
public interface ISsrRawTextFeature
{
    /// <summary>
    /// <c>true</c> when text content must be written verbatim during server rendering.
    /// </summary>
    bool IsRawText { get; }
}
