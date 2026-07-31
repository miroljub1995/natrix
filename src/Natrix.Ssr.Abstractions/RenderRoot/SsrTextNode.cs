using System.IO.Pipelines;
using System.Text;
using Natrix.Signals;

namespace Natrix.Ssr.Abstractions.RenderRoot;

public sealed class SsrTextNode : ISsrNode
{
    public IReadOnlySignal<string>? TextContent { get; init; }

    /// <summary>
    /// Writes the content verbatim instead of HTML-escaping it. Only valid inside
    /// raw text elements (<c>script</c>, <c>style</c>), where the HTML parser does
    /// not decode character references.
    /// </summary>
    public bool Raw { get; init; }

    public ValueTask WriteAsync(PipeWriter writer, bool sortAttributes, CancellationToken cancellationToken = default)
    {
        var text = TextContent?.Value ?? string.Empty;

        if (Raw)
        {
            Encoding.UTF8.GetBytes(text, writer);
        }
        else
        {
            SsrHtmlEncoder.WriteEscaped(writer, text, escapeQuotes: false);
        }

        return ValueTask.CompletedTask;
    }
}
