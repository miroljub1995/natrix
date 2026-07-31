using System.IO.Pipelines;
using System.Text;

namespace Natrix.Ssr.Abstractions.RenderRoot;

/// <summary>
/// Minimal HTML escaping for server-rendered output. Without this, any signal
/// value containing markup characters would be emitted verbatim, which both
/// corrupts the document structure (and therefore hydration) and allows HTML
/// injection through rendered text or attribute values.
/// </summary>
internal static class SsrHtmlEncoder
{
    public static void WriteEscaped(PipeWriter writer, string text, bool escapeQuotes)
    {
        var span = text.AsSpan();
        var start = 0;

        for (var i = 0; i < span.Length; i++)
        {
            var replacement = span[i] switch
            {
                '&' => "&amp;",
                '<' => "&lt;",
                '>' => "&gt;",
                '"' when escapeQuotes => "&quot;",
                _ => null,
            };

            if (replacement is null)
            {
                continue;
            }

            if (i > start)
            {
                Encoding.UTF8.GetBytes(span[start..i], writer);
            }

            Encoding.UTF8.GetBytes(replacement, writer);
            start = i + 1;
        }

        if (start < span.Length)
        {
            Encoding.UTF8.GetBytes(span[start..], writer);
        }
    }
}
