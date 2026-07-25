using System.IO.Pipelines;
using System.Text;
using Natrix.Signals;

namespace Natrix.Ssr.Abstractions.RenderRoot;

public sealed class SsrTextNode : ISsrNode
{
    public IReadOnlySignal<string>? TextContent { get; init; }

    public ValueTask WriteAsync(PipeWriter writer, bool sortAttributes, CancellationToken cancellationToken = default)
    {
        Encoding.UTF8.GetBytes(TextContent?.Value ?? string.Empty, writer);
        return ValueTask.CompletedTask;
    }
}
