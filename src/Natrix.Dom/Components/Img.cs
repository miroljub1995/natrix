using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ImgProps : GlobalHtmlComponentProps<HTMLImageElement>
{
    private static readonly object s_altKey = new();

    public IReadOnlySignal<string>? Alt
    {
        get => Get<IReadOnlySignal<string>>(s_altKey);
        init => Set(
            s_altKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Alt = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("alt", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_srcKey = new();

    public IReadOnlySignal<string>? Src
    {
        get => Get<IReadOnlySignal<string>>(s_srcKey);
        init => Set(
            s_srcKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Src = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("src", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_srcsetKey = new();

    public IReadOnlySignal<string>? Srcset
    {
        get => Get<IReadOnlySignal<string>>(s_srcsetKey);
        init => Set(
            s_srcsetKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Srcset = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("srcset", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_sizesKey = new();

    public IReadOnlySignal<string>? Sizes
    {
        get => Get<IReadOnlySignal<string>>(s_sizesKey);
        init => Set(
            s_sizesKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Sizes = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("sizes", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_crossOriginKey = new();

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get<IReadOnlySignal<string?>>(s_crossOriginKey);
        init => Set(
            s_crossOriginKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.CrossOrigin = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("crossorigin", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_useMapKey = new();

    public IReadOnlySignal<string>? UseMap
    {
        get => Get<IReadOnlySignal<string>>(s_useMapKey);
        init => Set(
            s_useMapKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.UseMap = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("usemap", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_isMapKey = new();

    public IReadOnlySignal<bool>? IsMap
    {
        get => Get<IReadOnlySignal<bool>>(s_isMapKey);
        init => Set(
            s_isMapKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.IsMap = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("ismap", (IReadOnlySignal<bool>)s));
    }

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

    private static readonly object s_decodingKey = new();

    public IReadOnlySignal<string>? Decoding
    {
        get => Get<IReadOnlySignal<string>>(s_decodingKey);
        init => Set(
            s_decodingKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Decoding = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("decoding", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_fetchPriorityKey = new();

    public IReadOnlySignal<string>? FetchPriority
    {
        get => Get<IReadOnlySignal<string>>(s_fetchPriorityKey);
        init => Set(
            s_fetchPriorityKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.FetchPriority = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("fetchpriority", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_loadingKey = new();

    public IReadOnlySignal<string>? Loading
    {
        get => Get<IReadOnlySignal<string>>(s_loadingKey);
        init => Set(
            s_loadingKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Loading = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("loading", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_referrerPolicyKey = new();

    public IReadOnlySignal<string>? ReferrerPolicy
    {
        get => Get<IReadOnlySignal<string>>(s_referrerPolicyKey);
        init => Set(
            s_referrerPolicyKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.ReferrerPolicy = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("referrerpolicy", (IReadOnlySignal<string>)s));
    }
}

public class ImgEvents : HtmlElementComponentEvents<HTMLImageElement>
{
}

public class Img() : BaseVoidDomComponent<HTMLImageElement, ImgProps, ImgEvents>("img")
{
}
