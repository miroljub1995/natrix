using System.Reflection.Metadata;
using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.TailwindCss;

/// <summary>
/// Renders the generated stylesheet into a <c>&lt;style&gt;</c> element.
/// </summary>
/// <remarks>
/// Use this rather than a bare <see cref="Style"/> so the element is findable when hot reload is
/// active — see
/// <see cref="NatrixHostBuilderTailwindCssExtensions.UseTailwindCssHotReload"/>, which replaces its
/// contents as deltas arrive.
/// </remarks>
/// <example>
/// <code>
/// new TailwindCssStyle { Css = Styles.GetCss() }
/// </code>
/// </example>
public sealed class TailwindCssStyle : IComponent
{
    /// <summary>The generated stylesheet, e.g. <c>Styles.GetCss()</c>.</summary>
    public required string Css { get; init; }

    // Rendered only when the feature switch is on, so a published page carries no stray id. Both
    // sides read the same switch in their own process: the server writes the id only when it could
    // be useful, and the browser goes looking under exactly the same condition.
    private static readonly IReadOnlySignal<string>? s_id =
        MetadataUpdater.IsSupported ? TailwindCssHotReload.StyleElementId.ToConstSignal() : null;

    private IComponent? _style;

    public void Mount(IRenderSlot slot)
    {
        if (_style is not null)
        {
            throw new InvalidOperationException("Component is already mounted.");
        }

        _style = new Style
        {
            Props = new StyleProps { Id = s_id },
            Children = [new DomText { Text = Css.ToConstSignal() }],
        };

        _style.Mount(slot);
    }

    public void Unmount()
    {
        _style?.Unmount();
        _style = null;
    }
}
