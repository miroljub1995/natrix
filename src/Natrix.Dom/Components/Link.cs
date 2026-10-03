using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class LinkProps : GlobalHtmlComponentProps<HTMLLinkElement>
{
    private static readonly PropDescriptor<string> s_href = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Href = s.Value;
        },
        static (el, s) => el.SetAttribute("href", s));

    public IReadOnlySignal<string>? Href
    {
        get => Get(s_href);
        init => Set(s_href, value);
    }

    private static readonly PropDescriptor<string?> s_crossOrigin = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.CrossOrigin = s.Value;
        },
        static (el, s) => el.SetNullableString("crossorigin", s));

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get(s_crossOrigin);
        init => Set(s_crossOrigin, value);
    }

    private static readonly PropDescriptor<string> s_rel = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Rel = s.Value;
        },
        static (el, s) => el.SetAttribute("rel", s));

    public IReadOnlySignal<string>? Rel
    {
        get => Get(s_rel);
        init => Set(s_rel, value);
    }

    private static readonly PropDescriptor<string> s_as = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.As = s.Value;
        },
        static (el, s) => el.SetAttribute("as", s));

    public IReadOnlySignal<string>? As
    {
        get => Get(s_as);
        init => Set(s_as, value);
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

    private static readonly PropDescriptor<string> s_integrity = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Integrity = s.Value;
        },
        static (el, s) => el.SetAttribute("integrity", s));

    public IReadOnlySignal<string>? Integrity
    {
        get => Get(s_integrity);
        init => Set(s_integrity, value);
    }

    private static readonly PropDescriptor<string> s_hreflang = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Hreflang = s.Value;
        },
        static (el, s) => el.SetAttribute("hreflang", s));

    public IReadOnlySignal<string>? Hreflang
    {
        get => Get(s_hreflang);
        init => Set(s_hreflang, value);
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

    private static readonly PropDescriptor<string> s_referrerPolicy = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.ReferrerPolicy = s.Value;
        },
        static (el, s) => el.SetAttribute("referrerpolicy", s));

    public IReadOnlySignal<string>? ReferrerPolicy
    {
        get => Get(s_referrerPolicy);
        init => Set(s_referrerPolicy, value);
    }

    private static readonly PropDescriptor<bool> s_disabled = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Disabled = s.Value;
        },
        static (el, s) => el.SetBoolean("disabled", s));

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get(s_disabled);
        init => Set(s_disabled, value);
    }

    private static readonly PropDescriptor<string> s_fetchPriority = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.FetchPriority = s.Value;
        },
        static (el, s) => el.SetAttribute("fetchpriority", s));

    public IReadOnlySignal<string>? FetchPriority
    {
        get => Get(s_fetchPriority);
        init => Set(s_fetchPriority, value);
    }

    private static readonly PropDescriptor<string> s_blocking = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Blocking.Value = s.Value;
        },
        static (el, s) => el.SetAttribute("blocking", s));

    public IReadOnlySignal<string>? Blocking
    {
        get => Get(s_blocking);
        init => Set(s_blocking, value);
    }

    private static readonly PropDescriptor<string> s_imageSizes = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.ImageSizes = s.Value;
        },
        static (el, s) => el.SetAttribute("imagesizes", s));

    public IReadOnlySignal<string>? ImageSizes
    {
        get => Get(s_imageSizes);
        init => Set(s_imageSizes, value);
    }

    private static readonly PropDescriptor<string> s_imageSrcset = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.ImageSrcset = s.Value;
        },
        static (el, s) => el.SetAttribute("imagesrcset", s));

    public IReadOnlySignal<string>? ImageSrcset
    {
        get => Get(s_imageSrcset);
        init => Set(s_imageSrcset, value);
    }
}

public class LinkEvents : HtmlElementComponentEvents<HTMLLinkElement>
{
}

public class Link() : BaseVoidDomComponent<HTMLLinkElement, LinkProps, LinkEvents>("link")
{
}
