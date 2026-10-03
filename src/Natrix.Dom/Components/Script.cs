using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ScriptProps : GlobalHtmlComponentProps<HTMLScriptElement>
{
    private static readonly PropDescriptor<string> s_src = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Src = s.Value;
        },
        static (el, s) => el.SetAttribute("src", s));

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(s_src, value);
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

    private static readonly PropDescriptor<bool> s_noModule = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.NoModule = s.Value;
        },
        static (el, s) => el.SetBoolean("nomodule", s));

    public IReadOnlySignal<bool>? NoModule
    {
        get => Get(s_noModule);
        init => Set(s_noModule, value);
    }

    private static readonly PropDescriptor<bool> s_async = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Async = s.Value;
        },
        static (el, s) => el.SetBoolean("async", s));

    public IReadOnlySignal<bool>? Async
    {
        get => Get(s_async);
        init => Set(s_async, value);
    }

    private static readonly PropDescriptor<bool> s_defer = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Defer = s.Value;
        },
        static (el, s) => el.SetBoolean("defer", s));

    public IReadOnlySignal<bool>? Defer
    {
        get => Get(s_defer);
        init => Set(s_defer, value);
    }

    private static readonly PropDescriptor<string?> s_crossOrigin = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.CrossOrigin = s.Value;
        },
        static (el, s) => el.SetNullableString("crossorigin", s));

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get(s_crossOrigin);
        init => Set(s_crossOrigin, value);
    }

    private static readonly PropDescriptor<string> s_integrity = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Integrity = s.Value;
        },
        static (el, s) => el.SetAttribute("integrity", s));

    public IReadOnlySignal<string>? Integrity
    {
        get => Get(s_integrity);
        init => Set(s_integrity, value);
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

    private static readonly PropDescriptor<string> s_fetchPriority = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.FetchPriority = s.Value;
        },
        static (el, s) => el.SetAttribute("fetchpriority", s));

    public IReadOnlySignal<string>? FetchPriority
    {
        get => Get(s_fetchPriority);
        init => Set(s_fetchPriority, value);
    }

    private static readonly PropDescriptor<string> s_blocking = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Blocking.Value = s.Value;
        },
        static (el, s) => el.SetAttribute("blocking", s));

    public IReadOnlySignal<string>? Blocking
    {
        get => Get(s_blocking);
        init => Set(s_blocking, value);
    }
}

public class ScriptEvents : HtmlElementComponentEvents<HTMLScriptElement>
{
}

public class Script() : BaseNonVoidDomComponent<HTMLScriptElement, ScriptProps, ScriptEvents>("script")
{
    protected override IComponent[]? GetChildren()
    {
        var children = base.GetChildren();

        return children is { Length: > 0 }
            ? [new SsrRawTextScope { Children = children }]
            : children;
    }
}
