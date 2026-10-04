using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class EmbedProps : GlobalHtmlComponentProps<HTMLEmbedElement>
{
    private static PropDescriptor<string>? s_src;

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(ref s_src, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Src = s.Value;
            },
            static (el, s) => el.SetAttribute("src", s)));
    }

    private static PropDescriptor<string>? s_type;

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(ref s_type, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Type = s.Value;
            },
            static (el, s) => el.SetAttribute("type", s)));
    }

    private static PropDescriptor<string>? s_width;

    public IReadOnlySignal<string>? Width
    {
        get => Get(s_width);
        init => Set(ref s_width, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Width = s.Value;
            },
            static (el, s) => el.SetAttribute("width", s)));
    }

    private static PropDescriptor<string>? s_height;

    public IReadOnlySignal<string>? Height
    {
        get => Get(s_height);
        init => Set(ref s_height, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Height = s.Value;
            },
            static (el, s) => el.SetAttribute("height", s)));
    }
}

public class EmbedEvents : HtmlElementComponentEvents<HTMLEmbedElement>
{
}

public class Embed() : BaseVoidDomComponent<HTMLEmbedElement, EmbedProps, EmbedEvents>("embed")
{
}
