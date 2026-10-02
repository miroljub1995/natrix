using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class AreaProps : GlobalHtmlComponentProps<HTMLAreaElement>
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

    private static readonly object s_coordsKey = new();

    public IReadOnlySignal<string>? Coords
    {
        get => Get<IReadOnlySignal<string>>(s_coordsKey);
        init => Set(
            s_coordsKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Coords = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("coords", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_shapeKey = new();

    public IReadOnlySignal<string>? Shape
    {
        get => Get<IReadOnlySignal<string>>(s_shapeKey);
        init => Set(
            s_shapeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Shape = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("shape", (IReadOnlySignal<string>)s));
    }

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

public class AreaEvents : HtmlElementComponentEvents<HTMLAreaElement>
{
}

public class Area() : BaseVoidDomComponent<HTMLAreaElement, AreaProps, AreaEvents>("area")
{
}
