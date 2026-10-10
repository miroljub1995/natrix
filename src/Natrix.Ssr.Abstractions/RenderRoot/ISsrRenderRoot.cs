using System.IO.Pipelines;
using Natrix.Core.RenderRoot;

namespace Natrix.Ssr.Abstractions.RenderRoot;

public interface ISsrRenderRoot : IRenderRoot
{
    ValueTask WriteAsync(PipeWriter writer, bool sortAttributes = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// The nodes currently mounted in this root, in document order.
    /// </summary>
    IEnumerable<ISsrNode> GetNodes();
}