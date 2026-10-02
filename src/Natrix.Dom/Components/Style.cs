using System.Diagnostics.CodeAnalysis;
using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class StyleProps : GlobalHtmlComponentProps<HTMLStyleElement>
{
    private static readonly object s_disabledKey = new();

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get<IReadOnlySignal<bool>>(s_disabledKey);
        init => Set(
            s_disabledKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Disabled = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("disabled", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_mediaKey = new();

    public IReadOnlySignal<string>? Media
    {
        get => Get<IReadOnlySignal<string>>(s_mediaKey);
        init => Set(
            s_mediaKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Media = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("media", (IReadOnlySignal<string>)s));
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

public class StyleEvents : HtmlElementComponentEvents<HTMLStyleElement>
{
}

public class Style() : BaseNonVoidDomComponent<HTMLStyleElement, StyleProps, StyleEvents>("style")
{
    protected override IComponent[]? GetChildren()
    {
        var children = base.GetChildren();

        return children is { Length: > 0 }
            ? [new SsrRawTextScope { Children = children }]
            : children;
    }
}
