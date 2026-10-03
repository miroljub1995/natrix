using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class IFrameProps : GlobalHtmlComponentProps<HTMLIFrameElement>
{
    private static PropDescriptor<string>? s_src;

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(ref s_src, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Src = s.Value;
            },
            static (el, s) => el.SetAttribute("src", s)));
    }

    private static PropDescriptor<string>? s_name;

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(ref s_name, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Name = s.Value;
            },
            static (el, s) => el.SetAttribute("name", s)));
    }

    private static PropDescriptor<string>? s_allow;

    public IReadOnlySignal<string>? Allow
    {
        get => Get(s_allow);
        init => Set(ref s_allow, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Allow = s.Value;
            },
            static (el, s) => el.SetAttribute("allow", s)));
    }

    private static PropDescriptor<bool>? s_allowFullscreen;

    public IReadOnlySignal<bool>? AllowFullscreen
    {
        get => Get(s_allowFullscreen);
        init => Set(ref s_allowFullscreen, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AllowFullscreen = s.Value;
            },
            static (el, s) => el.SetBoolean("allowfullscreen", s)));
    }

    private static PropDescriptor<string>? s_width;

    public IReadOnlySignal<string>? Width
    {
        get => Get(s_width);
        init => Set(ref s_width, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Width = s.Value;
            },
            static (el, s) => el.SetAttribute("width", s)));
    }

    private static PropDescriptor<string>? s_height;

    public IReadOnlySignal<string>? Height
    {
        get => Get(s_height);
        init => Set(ref s_height, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Height = s.Value;
            },
            static (el, s) => el.SetAttribute("height", s)));
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

    private static PropDescriptor<string>? s_loading;

    public IReadOnlySignal<string>? Loading
    {
        get => Get(s_loading);
        init => Set(ref s_loading, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Loading = s.Value;
            },
            static (el, s) => el.SetAttribute("loading", s)));
    }

    private static PropDescriptor<string>? s_sandbox;

    public IReadOnlySignal<string>? Sandbox
    {
        get => Get(s_sandbox);
        init => Set(ref s_sandbox, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Sandbox.Value = s.Value;
            },
            static (el, s) => el.SetAttribute("sandbox", s)));
    }

    private static PropDescriptor<string>? s_srcDoc;

    public IReadOnlySignal<string>? SrcDoc
    {
        get => Get(s_srcDoc);
        init => Set(ref s_srcDoc, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Srcdoc = s.Value;
            },
            static (el, s) => el.SetAttribute("srcdoc", s)));
    }
}

public class IFrameEvents : HtmlElementComponentEvents<HTMLIFrameElement>
{
}

public class IFrame() : BaseNonVoidDomComponent<HTMLIFrameElement, IFrameProps, IFrameEvents>("iframe")
{
}
