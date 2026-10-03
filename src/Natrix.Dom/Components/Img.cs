using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ImgProps : GlobalHtmlComponentProps<HTMLImageElement>
{
    private static PropDescriptor<string>? s_alt;

    public IReadOnlySignal<string>? Alt
    {
        get => Get(s_alt);
        init => Set(ref s_alt, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Alt = s.Value;
            },
            static (el, s) => el.SetAttribute("alt", s)));
    }

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

    private static PropDescriptor<string?>? s_crossOrigin;

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get(s_crossOrigin);
        init => Set(ref s_crossOrigin, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.CrossOrigin = s.Value;
            },
            static (el, s) => el.SetNullableString("crossorigin", s)));
    }

    private static PropDescriptor<string>? s_useMap;

    public IReadOnlySignal<string>? UseMap
    {
        get => Get(s_useMap);
        init => Set(ref s_useMap, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.UseMap = s.Value;
            },
            static (el, s) => el.SetAttribute("usemap", s)));
    }

    private static PropDescriptor<bool>? s_isMap;

    public IReadOnlySignal<bool>? IsMap
    {
        get => Get(s_isMap);
        init => Set(ref s_isMap, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.IsMap = s.Value;
            },
            static (el, s) => el.SetBoolean("ismap", s)));
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

    private static PropDescriptor<string>? s_decoding;

    public IReadOnlySignal<string>? Decoding
    {
        get => Get(s_decoding);
        init => Set(ref s_decoding, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Decoding = s.Value;
            },
            static (el, s) => el.SetAttribute("decoding", s)));
    }

    private static PropDescriptor<string>? s_fetchPriority;

    public IReadOnlySignal<string>? FetchPriority
    {
        get => Get(s_fetchPriority);
        init => Set(ref s_fetchPriority, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FetchPriority = s.Value;
            },
            static (el, s) => el.SetAttribute("fetchpriority", s)));
    }

    private static PropDescriptor<string>? s_loading;

    public IReadOnlySignal<string>? Loading
    {
        get => Get(s_loading);
        init => Set(ref s_loading, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Loading = s.Value;
            },
            static (el, s) => el.SetAttribute("loading", s)));
    }

    private static PropDescriptor<string>? s_referrerPolicy;

    public IReadOnlySignal<string>? ReferrerPolicy
    {
        get => Get(s_referrerPolicy);
        init => Set(ref s_referrerPolicy, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.ReferrerPolicy = s.Value;
            },
            static (el, s) => el.SetAttribute("referrerpolicy", s)));
    }
}

public class ImgEvents : HtmlElementComponentEvents<HTMLImageElement>
{
}

public class Img() : BaseVoidDomComponent<HTMLImageElement, ImgProps, ImgEvents>("img")
{
}
