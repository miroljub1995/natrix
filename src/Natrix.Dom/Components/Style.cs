using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class StyleProps : GlobalHtmlComponentProps<HTMLStyleElement>
{
    private static PropDescriptor<bool>? s_disabled;

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get(s_disabled);
        init => Set(ref s_disabled, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Disabled = s.Value;
            },
            static (el, s) => el.SetBoolean("disabled", s)));
    }

    private static PropDescriptor<string>? s_media;

    public IReadOnlySignal<string>? Media
    {
        get => Get(s_media);
        init => Set(ref s_media, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Media = s.Value;
            },
            static (el, s) => el.SetAttribute("media", s)));
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
