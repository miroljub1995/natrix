using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class SourceProps : GlobalHtmlComponentProps<HTMLSourceElement>
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

    private static PropDescriptor<string>? s_srcset;

    public IReadOnlySignal<string>? Srcset
    {
        get => Get(s_srcset);
        init => Set(ref s_srcset, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Srcset = s.Value;
            },
            static (el, s) => el.SetAttribute("srcset", s)));
    }

    private static PropDescriptor<string>? s_sizes;

    public IReadOnlySignal<string>? Sizes
    {
        get => Get(s_sizes);
        init => Set(ref s_sizes, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Sizes = s.Value;
            },
            static (el, s) => el.SetAttribute("sizes", s)));
    }

    private static PropDescriptor<string>? s_media;

    public IReadOnlySignal<string>? Media
    {
        get => Get(s_media);
        init => Set(ref s_media, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Media = s.Value;
            },
            static (el, s) => el.SetAttribute("media", s)));
    }

    private static PropDescriptor<uint>? s_width;

    public IReadOnlySignal<uint>? Width
    {
        get => Get(s_width);
        init => Set(ref s_width, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Width = s.Value;
            },
            static (el, s) => el.SetUInt("width", s)));
    }

    private static PropDescriptor<uint>? s_height;

    public IReadOnlySignal<uint>? Height
    {
        get => Get(s_height);
        init => Set(ref s_height, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Height = s.Value;
            },
            static (el, s) => el.SetUInt("height", s)));
    }
}

public class SourceEvents : HtmlElementComponentEvents<HTMLSourceElement>
{
}

public class Source() : BaseVoidDomComponent<HTMLSourceElement, SourceProps, SourceEvents>("source")
{
}
