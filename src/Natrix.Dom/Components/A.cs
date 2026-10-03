using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class AProps : GlobalHtmlComponentProps<HTMLAnchorElement>
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

    private static PropDescriptor<string>? s_target;

    public IReadOnlySignal<string>? Target
    {
        get => Get(s_target);
        init => Set(ref s_target, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Target = s.Value;
            },
            static (el, s) => el.SetAttribute("target", s)));
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

    private static PropDescriptor<string>? s_download;

    public IReadOnlySignal<string>? Download
    {
        get => Get(s_download);
        init => Set(ref s_download, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Download = s.Value;
            },
            static (el, s) => el.SetAttribute("download", s)));
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

    private static PropDescriptor<string>? s_ping;

    public IReadOnlySignal<string>? Ping
    {
        get => Get(s_ping);
        init => Set(ref s_ping, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Ping = s.Value;
            },
            static (el, s) => el.SetAttribute("ping", s)));
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
}

public class AEvents : HtmlElementComponentEvents<HTMLAnchorElement>
{
}

public class A() : BaseNonVoidDomComponent<HTMLAnchorElement, AProps, AEvents>("a")
{
}
