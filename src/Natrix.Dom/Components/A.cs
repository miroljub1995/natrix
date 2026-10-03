using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class AProps : GlobalHtmlComponentProps<HTMLAnchorElement>
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

    private static readonly PropDescriptor<string> s_target = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Target = s.Value;
        },
        static (el, s) => el.SetAttribute("target", s));

    public IReadOnlySignal<string>? Target
    {
        get => Get(s_target);
        init => Set(s_target, value);
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

    private static readonly PropDescriptor<string> s_download = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Download = s.Value;
        },
        static (el, s) => el.SetAttribute("download", s));

    public IReadOnlySignal<string>? Download
    {
        get => Get(s_download);
        init => Set(s_download, value);
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

    private static readonly PropDescriptor<string> s_ping = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Ping = s.Value;
        },
        static (el, s) => el.SetAttribute("ping", s));

    public IReadOnlySignal<string>? Ping
    {
        get => Get(s_ping);
        init => Set(s_ping, value);
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
}

public class AEvents : HtmlElementComponentEvents<HTMLAnchorElement>
{
}

public class A() : BaseNonVoidDomComponent<HTMLAnchorElement, AProps, AEvents>("a")
{
}
