using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class CanvasProps : GlobalHtmlComponentProps<HTMLCanvasElement>
{
    private static readonly object s_widthKey = new();

    public IReadOnlySignal<uint>? Width
    {
        get => Get<IReadOnlySignal<uint>>(s_widthKey);
        init => Set(
            s_widthKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Width = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("width", (IReadOnlySignal<uint>)s));
    }

    private static readonly object s_heightKey = new();

    public IReadOnlySignal<uint>? Height
    {
        get => Get<IReadOnlySignal<uint>>(s_heightKey);
        init => Set(
            s_heightKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Height = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("height", (IReadOnlySignal<uint>)s));
    }
}

public class CanvasEvents : HtmlElementComponentEvents<HTMLCanvasElement>
{
}

public class Canvas() : BaseNonVoidDomComponent<HTMLCanvasElement, CanvasProps, CanvasEvents>("canvas")
{
}
