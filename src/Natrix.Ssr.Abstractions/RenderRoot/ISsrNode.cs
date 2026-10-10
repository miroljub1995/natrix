using System.IO.Pipelines;

namespace Natrix.Ssr.Abstractions.RenderRoot;

public interface ISsrNode
{
    ValueTask WriteAsync(PipeWriter writer, bool sortAttributes, CancellationToken cancellationToken = default);

    /// <summary>
    /// The node's children, in document order; empty for nodes that cannot have any.
    /// </summary>
    IEnumerable<ISsrNode> GetChildNodes();
}
