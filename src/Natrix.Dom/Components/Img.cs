using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ImgProps : GlobalHtmlComponentProps<HTMLImageElement>
{
    private static readonly PropDescriptor<string> s_alt = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Alt = s.Value
            : null,
        static (el, s) => el.SetAttribute("alt", s));

    public IReadOnlySignal<string>? Alt
    {
        get => Get(s_alt);
        init => Set(s_alt, value);
    }

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

    private static readonly PropDescriptor<string?> s_crossOrigin = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.CrossOrigin = s.Value
            : null,
        static (el, s) => el.SetNullableString("crossorigin", s));

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get(s_crossOrigin);
        init => Set(s_crossOrigin, value);
    }

    private static readonly PropDescriptor<string> s_useMap = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.UseMap = s.Value
            : null,
        static (el, s) => el.SetAttribute("usemap", s));

    public IReadOnlySignal<string>? UseMap
    {
        get => Get(s_useMap);
        init => Set(s_useMap, value);
    }

    private static readonly PropDescriptor<bool> s_isMap = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.IsMap = s.Value
            : null,
        static (el, s) => el.SetBoolean("ismap", s));

    public IReadOnlySignal<bool>? IsMap
    {
        get => Get(s_isMap);
        init => Set(s_isMap, value);
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

    private static readonly PropDescriptor<string> s_decoding = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Decoding = s.Value
            : null,
        static (el, s) => el.SetAttribute("decoding", s));

    public IReadOnlySignal<string>? Decoding
    {
        get => Get(s_decoding);
        init => Set(s_decoding, value);
    }

    private static readonly PropDescriptor<string> s_fetchPriority = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FetchPriority = s.Value
            : null,
        static (el, s) => el.SetAttribute("fetchpriority", s));

    public IReadOnlySignal<string>? FetchPriority
    {
        get => Get(s_fetchPriority);
        init => Set(s_fetchPriority, value);
    }

    private static readonly PropDescriptor<string> s_loading = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Loading = s.Value
            : null,
        static (el, s) => el.SetAttribute("loading", s));

    public IReadOnlySignal<string>? Loading
    {
        get => Get(s_loading);
        init => Set(s_loading, value);
    }

    private static readonly PropDescriptor<string> s_referrerPolicy = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.ReferrerPolicy = s.Value
            : null,
        static (el, s) => el.SetAttribute("referrerpolicy", s));

    public IReadOnlySignal<string>? ReferrerPolicy
    {
        get => Get(s_referrerPolicy);
        init => Set(s_referrerPolicy, value);
    }
}

public class ImgEvents : HtmlElementComponentEvents<HTMLImageElement>
{
}

public class Img() : BaseVoidDomComponent<HTMLImageElement, ImgProps, ImgEvents>("img")
{
}
