using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class SourceProps : GlobalHtmlComponentProps<HTMLSourceElement>
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

    private static readonly PropDescriptor<string> s_srcset = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Srcset = s.Value;
        },
        static (el, s) => el.SetAttribute("srcset", s));

    public IReadOnlySignal<string>? Srcset
    {
        get => Get(s_srcset);
        init => Set(s_srcset, value);
    }

    private static readonly PropDescriptor<string> s_sizes = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Sizes = s.Value;
        },
        static (el, s) => el.SetAttribute("sizes", s));

    public IReadOnlySignal<string>? Sizes
    {
        get => Get(s_sizes);
        init => Set(s_sizes, value);
    }

    private static readonly PropDescriptor<string> s_media = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Media = s.Value;
        },
        static (el, s) => el.SetAttribute("media", s));

    public IReadOnlySignal<string>? Media
    {
        get => Get(s_media);
        init => Set(s_media, value);
    }

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

public class SourceEvents : HtmlElementComponentEvents<HTMLSourceElement>
{
}

public class Source() : BaseVoidDomComponent<HTMLSourceElement, SourceProps, SourceEvents>("source")
{
}
