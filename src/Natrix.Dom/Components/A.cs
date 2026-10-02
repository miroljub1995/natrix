using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class AProps : GlobalHtmlComponentProps<HTMLAnchorElement>
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

    private static readonly object s_targetKey = new();

    public IReadOnlySignal<string>? Target
    {
        get => Get<IReadOnlySignal<string>>(s_targetKey);
        init => Set(
            s_targetKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Target = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("target", (IReadOnlySignal<string>)s));
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

    private static readonly object s_downloadKey = new();

    public IReadOnlySignal<string>? Download
    {
        get => Get<IReadOnlySignal<string>>(s_downloadKey);
        init => Set(
            s_downloadKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Download = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("download", (IReadOnlySignal<string>)s));
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

    private static readonly object s_pingKey = new();

    public IReadOnlySignal<string>? Ping
    {
        get => Get<IReadOnlySignal<string>>(s_pingKey);
        init => Set(
            s_pingKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Ping = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("ping", (IReadOnlySignal<string>)s));
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
}

public class AEvents : HtmlElementComponentEvents<HTMLAnchorElement>
{
}

public class A() : BaseNonVoidDomComponent<HTMLAnchorElement, AProps, AEvents>("a")
{
}
