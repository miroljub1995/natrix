using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class CanvasProps : GlobalHtmlComponentProps<HTMLCanvasElement>
{
    private static readonly PropDescriptor<uint> s_width = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Width = s.Value;
        },
        static (el, s) => el.SetUInt("width", s));

    public IReadOnlySignal<uint>? Width
    {
        get => Get(s_width);
        init => Set(s_width, value);
    }

    private static readonly PropDescriptor<uint> s_height = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Height = s.Value;
        },
        static (el, s) => el.SetUInt("height", s));

    public IReadOnlySignal<uint>? Height
    {
        get => Get(s_height);
        init => Set(s_height, value);
    }
}

public class CanvasEvents : HtmlElementComponentEvents<HTMLCanvasElement>
{
}

public class Canvas() : BaseNonVoidDomComponent<HTMLCanvasElement, CanvasProps, CanvasEvents>("canvas")
{
}
