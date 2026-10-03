using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class LinkProps : GlobalHtmlComponentProps<HTMLLinkElement>
{
    private static readonly PropDescriptor<string> s_href = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Href = s.Value
            : null,
        static (el, s) => el.SetAttribute("href", s));

    public IReadOnlySignal<string>? Href
    {
        get => Get(s_href);
        init => Set(s_href, value);
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

    private static readonly PropDescriptor<string> s_rel = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Rel = s.Value
            : null,
        static (el, s) => el.SetAttribute("rel", s));

    public IReadOnlySignal<string>? Rel
    {
        get => Get(s_rel);
        init => Set(s_rel, value);
    }

    private static readonly PropDescriptor<string> s_as = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.As = s.Value
            : null,
        static (el, s) => el.SetAttribute("as", s));

    public IReadOnlySignal<string>? As
    {
        get => Get(s_as);
        init => Set(s_as, value);
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

    private static readonly PropDescriptor<string> s_integrity = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Integrity = s.Value
            : null,
        static (el, s) => el.SetAttribute("integrity", s));

    public IReadOnlySignal<string>? Integrity
    {
        get => Get(s_integrity);
        init => Set(s_integrity, value);
    }

    private static readonly PropDescriptor<string> s_hreflang = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Hreflang = s.Value
            : null,
        static (el, s) => el.SetAttribute("hreflang", s));

    public IReadOnlySignal<string>? Hreflang
    {
        get => Get(s_hreflang);
        init => Set(s_hreflang, value);
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

    private static readonly PropDescriptor<bool> s_disabled = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Disabled = s.Value
            : null,
        static (el, s) => el.SetBoolean("disabled", s));

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get(s_disabled);
        init => Set(s_disabled, value);
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

    private static readonly PropDescriptor<string> s_blocking = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Blocking.Value = s.Value
            : null,
        static (el, s) => el.SetAttribute("blocking", s));

    public IReadOnlySignal<string>? Blocking
    {
        get => Get(s_blocking);
        init => Set(s_blocking, value);
    }

    private static readonly PropDescriptor<string> s_imageSizes = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.ImageSizes = s.Value
            : null,
        static (el, s) => el.SetAttribute("imagesizes", s));

    public IReadOnlySignal<string>? ImageSizes
    {
        get => Get(s_imageSizes);
        init => Set(s_imageSizes, value);
    }

    private static readonly PropDescriptor<string> s_imageSrcset = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.ImageSrcset = s.Value
            : null,
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
