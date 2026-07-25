using System.IO.Pipelines;

namespace Natrix.Ssr.Abstractions.RenderRoot;

public interface ISsrNode
{
    ValueTask WriteAsync(PipeWriter writer, bool sortAttributes, CancellationToken cancellationToken = default);
}
