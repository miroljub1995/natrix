using System.IO.Pipelines;
using System.Text;
using Natrix.Core.Components;
using Natrix.Ssr.RenderRoot;

namespace Natrix.Query.Tests.TestUtils;

/// <summary>Input for <see cref="Probe"/>.</summary>
internal sealed class ProbeProps
{
    /// <summary>Runs during the component's setup, where the composables are legal to call.</summary>
    public required Action Setup { get; init; }

    /// <summary>What the probe renders.</summary>
    public IComponent[] Children { get; init; } = [];
}

/// <summary>
/// A component whose only job is to run a lambda inside a real setup phase, so composables can
/// be exercised with the lifecycle they are written for.
/// </summary>
internal sealed class Probe : BaseComponent<ProbeProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;
        Props.Setup();
        return Props.Children;
    }
}

internal static class SsrRender
{
    /// <summary>Renders what a server-side root has produced so far into markup.</summary>
    public static async Task<string> RenderAsync(SsrRenderRoot root)
    {
        var pipe = new Pipe();
        await root.WriteAsync(pipe.Writer, true);
        await pipe.Writer.CompleteAsync();

        var builder = new StringBuilder();
        while (true)
        {
            var result = await pipe.Reader.ReadAsync();
            foreach (var segment in result.Buffer)
            {
                builder.Append(Encoding.UTF8.GetString(segment.Span));
            }

            pipe.Reader.AdvanceTo(result.Buffer.End);
            if (result.IsCompleted)
            {
                break;
            }
        }

        await pipe.Reader.CompleteAsync();
        return builder.ToString();
    }
}
