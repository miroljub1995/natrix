using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class LinkProps : GlobalHtmlComponentProps<HTMLLinkElement>
{
    private static PropDescriptor<string>? s_href;

    public IReadOnlySignal<string>? Href
    {
        get => Get(s_href);
        init => Set(ref s_href, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Href = s.Value;
            },
            static (el, s) => el.SetAttribute("href", s)));
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

    private static PropDescriptor<string>? s_rel;

    public IReadOnlySignal<string>? Rel
    {
        get => Get(s_rel);
        init => Set(ref s_rel, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Rel = s.Value;
            },
            static (el, s) => el.SetAttribute("rel", s)));
    }

    private static PropDescriptor<string>? s_as;

    public IReadOnlySignal<string>? As
    {
        get => Get(s_as);
        init => Set(ref s_as, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.As = s.Value;
            },
            static (el, s) => el.SetAttribute("as", s)));
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

    private static PropDescriptor<string>? s_integrity;

    public IReadOnlySignal<string>? Integrity
    {
        get => Get(s_integrity);
        init => Set(ref s_integrity, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Integrity = s.Value;
            },
            static (el, s) => el.SetAttribute("integrity", s)));
    }

    private static PropDescriptor<string>? s_hreflang;

    public IReadOnlySignal<string>? Hreflang
    {
        get => Get(s_hreflang);
        init => Set(ref s_hreflang, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Hreflang = s.Value;
            },
            static (el, s) => el.SetAttribute("hreflang", s)));
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

    private static PropDescriptor<bool>? s_disabled;

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get(s_disabled);
        init => Set(ref s_disabled, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Disabled = s.Value;
            },
            static (el, s) => el.SetBoolean("disabled", s)));
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

    private static PropDescriptor<string>? s_blocking;

    public IReadOnlySignal<string>? Blocking
    {
        get => Get(s_blocking);
        init => Set(ref s_blocking, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Blocking.Value = s.Value;
            },
            static (el, s) => el.SetAttribute("blocking", s)));
    }

    private static PropDescriptor<string>? s_imageSizes;

    public IReadOnlySignal<string>? ImageSizes
    {
        get => Get(s_imageSizes);
        init => Set(ref s_imageSizes, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.ImageSizes = s.Value;
            },
            static (el, s) => el.SetAttribute("imagesizes", s)));
    }

    private static PropDescriptor<string>? s_imageSrcset;

    public IReadOnlySignal<string>? ImageSrcset
    {
        get => Get(s_imageSrcset);
        init => Set(ref s_imageSrcset, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.ImageSrcset = s.Value;
            },
            static (el, s) => el.SetAttribute("imagesrcset", s)));
    }
}

public class LinkEvents : HtmlElementComponentEvents<HTMLLinkElement>
{
}

public class Link() : BaseVoidDomComponent<HTMLLinkElement, LinkProps, LinkEvents>("link")
{
}
