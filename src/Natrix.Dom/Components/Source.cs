using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class SourceProps : GlobalHtmlComponentProps<HTMLSourceElement>
{
    private static readonly PropDescriptor<string> s_src = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Src = s.Value
            : null,
        static (el, s) => el.SetAttribute("src", s));

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(s_src, value);
    }

    private static readonly PropDescriptor<string> s_type = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Type = s.Value
            : null,
        static (el, s) => el.SetAttribute("type", s));

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(s_type, value);
    }

    private static readonly PropDescriptor<string> s_srcset = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Srcset = s.Value
            : null,
        static (el, s) => el.SetAttribute("srcset", s));

    public IReadOnlySignal<string>? Srcset
    {
        get => Get(s_srcset);
        init => Set(s_srcset, value);
    }

    private static readonly PropDescriptor<string> s_sizes = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Sizes = s.Value
            : null,
        static (el, s) => el.SetAttribute("sizes", s));

    public IReadOnlySignal<string>? Sizes
    {
        get => Get(s_sizes);
        init => Set(s_sizes, value);
    }

    private static readonly PropDescriptor<string> s_media = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Media = s.Value
            : null,
        static (el, s) => el.SetAttribute("media", s));

    public IReadOnlySignal<string>? Media
    {
        get => Get(s_media);
        init => Set(s_media, value);
    }

    private static readonly PropDescriptor<uint> s_width = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Width = s.Value
            : null,
        static (el, s) => el.SetUInt("width", s));

    public IReadOnlySignal<uint>? Width
    {
        get => Get(s_width);
        init => Set(s_width, value);
    }

    private static readonly PropDescriptor<uint> s_height = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Height = s.Value
            : null,
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
