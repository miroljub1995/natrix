using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class LinkProps : GlobalHtmlComponentProps<HTMLLinkElement>
{
    private static readonly object s_hrefKey = new();

    public IReadOnlySignal<string>? Href
    {
        get => Get<IReadOnlySignal<string>>(s_hrefKey);
        init => Set(
            s_hrefKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Href = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("href", (IReadOnlySignal<string>)s));
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

    private static readonly object s_relKey = new();

    public IReadOnlySignal<string>? Rel
    {
        get => Get<IReadOnlySignal<string>>(s_relKey);
        init => Set(
            s_relKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Rel = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("rel", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_asKey = new();

    public IReadOnlySignal<string>? As
    {
        get => Get<IReadOnlySignal<string>>(s_asKey);
        init => Set(
            s_asKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.As = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("as", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_mediaKey = new();

    public IReadOnlySignal<string>? Media
    {
        get => Get<IReadOnlySignal<string>>(s_mediaKey);
        init => Set(
            s_mediaKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Media = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("media", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_integrityKey = new();

    public IReadOnlySignal<string>? Integrity
    {
        get => Get<IReadOnlySignal<string>>(s_integrityKey);
        init => Set(
            s_integrityKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Integrity = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("integrity", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_hreflangKey = new();

    public IReadOnlySignal<string>? Hreflang
    {
        get => Get<IReadOnlySignal<string>>(s_hreflangKey);
        init => Set(
            s_hreflangKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Hreflang = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("hreflang", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_typeKey = new();

    public IReadOnlySignal<string>? Type
    {
        get => Get<IReadOnlySignal<string>>(s_typeKey);
        init => Set(
            s_typeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Type = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("type", (IReadOnlySignal<string>)s));
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

    private static readonly object s_disabledKey = new();

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get<IReadOnlySignal<bool>>(s_disabledKey);
        init => Set(
            s_disabledKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Disabled = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("disabled", (IReadOnlySignal<bool>)s));
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

    private static readonly object s_blockingKey = new();

    public IReadOnlySignal<string>? Blocking
    {
        get => Get<IReadOnlySignal<string>>(s_blockingKey);
        init => Set(
            s_blockingKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Blocking.Value = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("blocking", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_imageSizesKey = new();

    public IReadOnlySignal<string>? ImageSizes
    {
        get => Get<IReadOnlySignal<string>>(s_imageSizesKey);
        init => Set(
            s_imageSizesKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.ImageSizes = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("imagesizes", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_imageSrcsetKey = new();

    public IReadOnlySignal<string>? ImageSrcset
    {
        get => Get<IReadOnlySignal<string>>(s_imageSrcsetKey);
        init => Set(
            s_imageSrcsetKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.ImageSrcset = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("imagesrcset", (IReadOnlySignal<string>)s));
    }
}

public class LinkEvents : HtmlElementComponentEvents<HTMLLinkElement>
{
}

public class Link() : BaseVoidDomComponent<HTMLLinkElement, LinkProps, LinkEvents>("link")
{
}
