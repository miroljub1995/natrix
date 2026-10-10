using System.IO.Pipelines;
using System.Text;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Ssr.RenderRoot;

namespace Natrix.Dom.Server.Tests;

internal static class SsrRenderer
{
    public static async Task<string> RenderAsync(Func<IComponent> root)
    {
        var (renderRoot, host) = Mount(root);
        using (host)
        {
            return await WriteAsync(renderRoot);
        }
    }

    /// <summary>
    /// Mounts the tree on a server host and keeps it mounted, so a test can change signals before
    /// writing the page.
    /// </summary>
    public static (SsrRenderRoot Root, IDisposable Host) Mount(Func<IComponent> root)
    {
        var renderRoot = new SsrRenderRoot();
        var host = new NatrixHostBuilder()
            .UseRootRenderer(renderRoot)
            .UseRootComponent(root)
            .Build()
            .Mount();

        return (renderRoot, host);
    }

    public static async Task<string> WriteAsync(SsrRenderRoot root)
    {
        var pipe = new Pipe();
        await root.WriteAsync(pipe.Writer, sortAttributes: true);
        await pipe.Writer.CompleteAsync();

        var sb = new StringBuilder();
        while (true)
        {
            var result = await pipe.Reader.ReadAsync();
            foreach (var segment in result.Buffer)
            {
                sb.Append(Encoding.UTF8.GetString(segment.Span));
            }

            pipe.Reader.AdvanceTo(result.Buffer.End);
            if (result.IsCompleted)
            {
                break;
            }
        }

        await pipe.Reader.CompleteAsync();
        return sb.ToString();
    }
}
