using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class IFrameProps : GlobalHtmlComponentProps<HTMLIFrameElement>
{
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

    private static readonly object s_nameKey = new();

    public IReadOnlySignal<string>? Name
    {
        get => Get<IReadOnlySignal<string>>(s_nameKey);
        init => Set(
            s_nameKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Name = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("name", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_allowKey = new();

    public IReadOnlySignal<string>? Allow
    {
        get => Get<IReadOnlySignal<string>>(s_allowKey);
        init => Set(
            s_allowKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Allow = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("allow", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_allowFullscreenKey = new();

    public IReadOnlySignal<bool>? AllowFullscreen
    {
        get => Get<IReadOnlySignal<bool>>(s_allowFullscreenKey);
        init => Set(
            s_allowFullscreenKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AllowFullscreen = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("allowfullscreen", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_widthKey = new();

    public IReadOnlySignal<string>? Width
    {
        get => Get<IReadOnlySignal<string>>(s_widthKey);
        init => Set(
            s_widthKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Width = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("width", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_heightKey = new();

    public IReadOnlySignal<string>? Height
    {
        get => Get<IReadOnlySignal<string>>(s_heightKey);
        init => Set(
            s_heightKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Height = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("height", (IReadOnlySignal<string>)s));
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

    private static readonly object s_sandboxKey = new();

    public IReadOnlySignal<string>? Sandbox
    {
        get => Get<IReadOnlySignal<string>>(s_sandboxKey);
        init => Set(
            s_sandboxKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Sandbox.Value = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("sandbox", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_srcDocKey = new();

    public IReadOnlySignal<string>? SrcDoc
    {
        get => Get<IReadOnlySignal<string>>(s_srcDocKey);
        init => Set(
            s_srcDocKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Srcdoc = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("srcdoc", (IReadOnlySignal<string>)s));
    }
}

public class IFrameEvents : HtmlElementComponentEvents<HTMLIFrameElement>
{
}

public class IFrame() : BaseNonVoidDomComponent<HTMLIFrameElement, IFrameProps, IFrameEvents>("iframe")
{
}
