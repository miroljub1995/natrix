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
    private static readonly PropDescriptor<bool> s_disabled = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Disabled = s.Value
            : null,
        static (el, s) => el.SetBoolean("disabled", s));

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get(s_disabled);
        init => Set(s_disabled, value);
    }

    private static readonly PropDescriptor<string> s_media = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Media = s.Value
            : null,
        static (el, s) => el.SetAttribute("media", s));

    public IReadOnlySignal<string>? Media
    {
        get => Get(s_media);
        init => Set(s_media, value);
    }

    private static readonly PropDescriptor<string> s_blocking = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Blocking.Value = s.Value
            : null,
        static (el, s) => el.SetAttribute("blocking", s));

    public IReadOnlySignal<string>? Blocking
    {
        get => Get(s_blocking);
        init => Set(s_blocking, value);
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
