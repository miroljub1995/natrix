using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class AreaProps : GlobalHtmlComponentProps<HTMLAreaElement>
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

    private static readonly PropDescriptor<string> s_coords = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Coords = s.Value
            : null,
        static (el, s) => el.SetAttribute("coords", s));

    public IReadOnlySignal<string>? Coords
    {
        get => Get(s_coords);
        init => Set(s_coords, value);
    }

    private static readonly PropDescriptor<string> s_shape = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Shape = s.Value
            : null,
        static (el, s) => el.SetAttribute("shape", s));

    public IReadOnlySignal<string>? Shape
    {
        get => Get(s_shape);
        init => Set(s_shape, value);
    }

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

    private static readonly PropDescriptor<string> s_target = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Target = s.Value
            : null,
        static (el, s) => el.SetAttribute("target", s));

    public IReadOnlySignal<string>? Target
    {
        get => Get(s_target);
        init => Set(s_target, value);
    }

    private static readonly PropDescriptor<string> s_download = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Download = s.Value
            : null,
        static (el, s) => el.SetAttribute("download", s));

    public IReadOnlySignal<string>? Download
    {
        get => Get(s_download);
        init => Set(s_download, value);
    }

    private static readonly PropDescriptor<string> s_ping = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Ping = s.Value
            : null,
        static (el, s) => el.SetAttribute("ping", s));

    public IReadOnlySignal<string>? Ping
    {
        get => Get(s_ping);
        init => Set(s_ping, value);
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

public class AreaEvents : HtmlElementComponentEvents<HTMLAreaElement>
{
}

public class Area() : BaseVoidDomComponent<HTMLAreaElement, AreaProps, AreaEvents>("area")
{
}
