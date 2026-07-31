namespace Natrix.Ssr.Abstractions.Features.RawText;

/// <inheritdoc cref="ISsrRawTextFeature" />
public sealed class SsrRawTextFeature : ISsrRawTextFeature
{
    /// <summary>Text content is written verbatim.</summary>
    public static readonly SsrRawTextFeature Raw = new(true);

    /// <summary>Text content is HTML-escaped.</summary>
    public static readonly SsrRawTextFeature Escaped = new(false);

    private SsrRawTextFeature(bool isRawText) => IsRawText = isRawText;

    public bool IsRawText { get; }
}
