using System.Diagnostics.CodeAnalysis;
using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ScriptProps : GlobalHtmlComponentProps<HTMLScriptElement>
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

    private static readonly object s_noModuleKey = new();

    public IReadOnlySignal<bool>? NoModule
    {
        get => Get<IReadOnlySignal<bool>>(s_noModuleKey);
        init => Set(
            s_noModuleKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.NoModule = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("nomodule", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_asyncKey = new();

    public IReadOnlySignal<bool>? Async
    {
        get => Get<IReadOnlySignal<bool>>(s_asyncKey);
        init => Set(
            s_asyncKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Async = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("async", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_deferKey = new();

    public IReadOnlySignal<bool>? Defer
    {
        get => Get<IReadOnlySignal<bool>>(s_deferKey);
        init => Set(
            s_deferKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Defer = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("defer", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_crossOriginKey = new();

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get<IReadOnlySignal<string?>>(s_crossOriginKey);
        init => Set(
            s_crossOriginKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.CrossOrigin = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("crossorigin", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_integrityKey = new();

    public IReadOnlySignal<string>? Integrity
    {
        get => Get<IReadOnlySignal<string>>(s_integrityKey);
        init => Set(
            s_integrityKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Integrity = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("integrity", (IReadOnlySignal<string>)s));
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

    private static readonly object s_fetchPriorityKey = new();

    public IReadOnlySignal<string>? FetchPriority
    {
        get => Get<IReadOnlySignal<string>>(s_fetchPriorityKey);
        init => Set(
            s_fetchPriorityKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.FetchPriority = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("fetchpriority", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_blockingKey = new();

    public IReadOnlySignal<string>? Blocking
    {
        get => Get<IReadOnlySignal<string>>(s_blockingKey);
        init => Set(
            s_blockingKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Blocking.Value = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("blocking", (IReadOnlySignal<string>)s));
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
