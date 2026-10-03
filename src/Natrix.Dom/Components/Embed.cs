using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class EmbedProps : GlobalHtmlComponentProps<HTMLEmbedElement>
{
    private static readonly PropDescriptor<string> s_src = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Src = s.Value;
        },
        static (el, s) => el.SetAttribute("src", s));

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(s_src, value);
    }

    private static readonly PropDescriptor<string> s_type = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Type = s.Value;
        },
        static (el, s) => el.SetAttribute("type", s));

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(s_type, value);
    }

    private static readonly PropDescriptor<string> s_width = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Width = s.Value;
        },
        static (el, s) => el.SetAttribute("width", s));

    public IReadOnlySignal<string>? Width
    {
        get => Get(s_width);
        init => Set(s_width, value);
    }

    private static readonly PropDescriptor<string> s_height = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Height = s.Value;
        },
        static (el, s) => el.SetAttribute("height", s));

    public IReadOnlySignal<string>? Height
    {
        get => Get(s_height);
        init => Set(s_height, value);
    }
}

public class EmbedEvents : HtmlElementComponentEvents<HTMLEmbedElement>
{
}

public class Embed() : BaseVoidDomComponent<HTMLEmbedElement, EmbedProps, EmbedEvents>("embed")
{
}
