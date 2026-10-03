using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class IFrameProps : GlobalHtmlComponentProps<HTMLIFrameElement>
{
    private static readonly PropDescriptor<string> s_src = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Src = s.Value
            : null,
        static (el, s) => el.SetAttribute("src", s));

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(s_src, value);
    }

    private static readonly PropDescriptor<string> s_name = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Name = s.Value
            : null,
        static (el, s) => el.SetAttribute("name", s));

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(s_name, value);
    }

    private static readonly PropDescriptor<string> s_allow = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Allow = s.Value
            : null,
        static (el, s) => el.SetAttribute("allow", s));

    public IReadOnlySignal<string>? Allow
    {
        get => Get(s_allow);
        init => Set(s_allow, value);
    }

    private static readonly PropDescriptor<bool> s_allowFullscreen = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AllowFullscreen = s.Value
            : null,
        static (el, s) => el.SetBoolean("allowfullscreen", s));

    public IReadOnlySignal<bool>? AllowFullscreen
    {
        get => Get(s_allowFullscreen);
        init => Set(s_allowFullscreen, value);
    }

    private static readonly PropDescriptor<string> s_width = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Width = s.Value
            : null,
        static (el, s) => el.SetAttribute("width", s));

    public IReadOnlySignal<string>? Width
    {
        get => Get(s_width);
        init => Set(s_width, value);
    }

    private static readonly PropDescriptor<string> s_height = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Height = s.Value
            : null,
        static (el, s) => el.SetAttribute("height", s));

    public IReadOnlySignal<string>? Height
    {
        get => Get(s_height);
        init => Set(s_height, value);
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

    private static readonly PropDescriptor<string> s_loading = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Loading = s.Value
            : null,
        static (el, s) => el.SetAttribute("loading", s));

    public IReadOnlySignal<string>? Loading
    {
        get => Get(s_loading);
        init => Set(s_loading, value);
    }

    private static readonly PropDescriptor<string> s_sandbox = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Sandbox.Value = s.Value
            : null,
        static (el, s) => el.SetAttribute("sandbox", s));

    public IReadOnlySignal<string>? Sandbox
    {
        get => Get(s_sandbox);
        init => Set(s_sandbox, value);
    }

    private static readonly PropDescriptor<string> s_srcDoc = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Srcdoc = s.Value
            : null,
        static (el, s) => el.SetAttribute("srcdoc", s));

    public IReadOnlySignal<string>? SrcDoc
    {
        get => Get(s_srcDoc);
        init => Set(s_srcDoc, value);
    }
}

public class IFrameEvents : HtmlElementComponentEvents<HTMLIFrameElement>
{
}

public class IFrame() : BaseNonVoidDomComponent<HTMLIFrameElement, IFrameProps, IFrameEvents>("iframe")
{
}
