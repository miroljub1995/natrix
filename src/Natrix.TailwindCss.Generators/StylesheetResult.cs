namespace Natrix.TailwindCss.Generators;

/// <summary>
/// The answer to an <c>@import</c>.
/// </summary>
/// <remarks>
/// Crosses into JavaScript as a host object, read there as <c>result.Error</c>,
/// <c>result.Path</c>, <c>result.Base</c> and <c>result.Content</c>. That is why it
/// carries the failure instead of throwing: a .NET exception thrown inside an engine
/// callback unwinds through the engine rather than becoming a JavaScript error
/// Tailwind can report.
/// </remarks>
internal sealed class StylesheetResult
{
    private StylesheetResult(string? path, string? basePath, string? content, string? error)
    {
        Path = path;
        Base = basePath;
        Content = content;
        Error = error;
    }

    public string? Path { get; }

    public string? Base { get; }

    public string? Content { get; }

    /// <summary>Non-null when the import could not be resolved.</summary>
    public string? Error { get; }

    public static StylesheetResult Found(string path, string basePath, string content) =>
        new(path, basePath, content, null);

    public static StylesheetResult NotFound(string error) => new(null, null, null, error);
}
