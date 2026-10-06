using System.IO.Pipelines;
using System.Text;
using Natrix.Composables.Dom.Head;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Ssr.RenderRoot;

namespace Natrix.Composables.Dom.Server.Tests;

internal sealed class ProbeProps
{
    /// <summary>
    /// Runs in the component's <c>Setup</c>, which is the only place a composable is valid.
    /// </summary>
    public required Action Body { get; init; }

    public IComponent[] Children { get; init; } = [];
}

/// <summary>
/// Minimal component whose only job is to run a test's setup body under real component
/// semantics: its own feature layer and its own effect scope.
/// </summary>
internal sealed class Probe : BaseComponent<ProbeProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        Props.Body();
        exposed = default;
        return Props.Children;
    }
}

internal static class Ssr
{
    public static Probe Probe(Action body, params IComponent[] children) =>
        new() { Props = new ProbeProps { Body = body, Children = children } };

    /// <summary>
    /// A page shaped like the ones the server renders: the head first, holding
    /// <see cref="HeadTags"/>, and the application in the body below it.
    /// </summary>
    public static IComponent Page(params IComponent[] body) => new Html
    {
        Props = new HtmlProps(),
        Children =
        [
            new Natrix.Dom.Components.Head { Props = new HeadProps(), Children = [new HeadTags { Props = new NoProps() }] },
            new Body { Props = new BodyProps(), Children = body },
        ],
    };

    /// <summary>
    /// Mounts the tree on a server host with the head managed, and keeps it mounted so a test can
    /// change things before writing the page.
    /// </summary>
    public static (SsrRenderRoot Root, IDisposable Host) Mount(Func<IComponent> root, Action<NatrixHostBuilder>? configure = null)
    {
        var renderRoot = new SsrRenderRoot();
        var builder = new NatrixHostBuilder()
            .UseRootRenderer(renderRoot)
            .UseServerHead()
            .UseRootComponent(root);

        configure?.Invoke(builder);

        return (renderRoot, builder.Build().Mount());
    }

    public static async Task<string> RenderAsync(Func<IComponent> root)
    {
        var (renderRoot, host) = Mount(root);
        using (host)
        {
            return await WriteAsync(renderRoot);
        }
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
