using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ScriptProps : GlobalHtmlComponentProps<HTMLScriptElement>
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

    private static PropDescriptor<bool>? s_noModule;

    public IReadOnlySignal<bool>? NoModule
    {
        get => Get(s_noModule);
        init => Set(ref s_noModule, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.NoModule = s.Value;
            },
            static (el, s) => el.SetBoolean("nomodule", s)));
    }

    private static PropDescriptor<bool>? s_async;

    public IReadOnlySignal<bool>? Async
    {
        get => Get(s_async);
        init => Set(ref s_async, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Async = s.Value;
            },
            static (el, s) => el.SetBoolean("async", s)));
    }

    private static PropDescriptor<bool>? s_defer;

    public IReadOnlySignal<bool>? Defer
    {
        get => Get(s_defer);
        init => Set(ref s_defer, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Defer = s.Value;
            },
            static (el, s) => el.SetBoolean("defer", s)));
    }

    private static PropDescriptor<string?>? s_crossOrigin;

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get(s_crossOrigin);
        init => Set(ref s_crossOrigin, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.CrossOrigin = s.Value;
            },
            static (el, s) => el.SetNullableString("crossorigin", s)));
    }

    private static PropDescriptor<string>? s_integrity;

    public IReadOnlySignal<string>? Integrity
    {
        get => Get(s_integrity);
        init => Set(ref s_integrity, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Integrity = s.Value;
            },
            static (el, s) => el.SetAttribute("integrity", s)));
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

    private static PropDescriptor<string>? s_fetchPriority;

    public IReadOnlySignal<string>? FetchPriority
    {
        get => Get(s_fetchPriority);
        init => Set(ref s_fetchPriority, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FetchPriority = s.Value;
            },
            static (el, s) => el.SetAttribute("fetchpriority", s)));
    }

    private static PropDescriptor<string>? s_blocking;

    public IReadOnlySignal<string>? Blocking
    {
        get => Get(s_blocking);
        init => Set(ref s_blocking, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Blocking.Value = s.Value;
            },
            static (el, s) => el.SetAttribute("blocking", s)));
    }
}

public class ScriptEvents : HtmlElementComponentEvents<HTMLScriptElement>
{
}

public class Script() : BaseNonVoidDomComponent<HTMLScriptElement, ScriptProps, ScriptEvents>("script")
{
    protected override IComponent[]? GetChildren(bool isSsr)
    {
        var children = base.GetChildren(isSsr);

        return children is { Length: > 0 }
            ? [new SsrRawTextScope { Children = children }]
            : children;
    }
}
