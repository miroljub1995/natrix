using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class BaseProps : GlobalHtmlComponentProps<HTMLBaseElement>
{
    private static PropDescriptor<string>? s_href;

    public IReadOnlySignal<string>? Href
    {
        get => Get(s_href);
        init => Set(ref s_href, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Href = s.Value;
            },
            static (el, s) => el.SetAttribute("href", s)));
    }

    private static PropDescriptor<string>? s_target;

    public IReadOnlySignal<string>? Target
    {
        get => Get(s_target);
        init => Set(ref s_target, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Target = s.Value;
            },
            static (el, s) => el.SetAttribute("target", s)));
    }
}

public class BaseEvents : HtmlElementComponentEvents<HTMLBaseElement>
{
}

public class Base() : BaseVoidDomComponent<HTMLBaseElement, BaseProps, BaseEvents>("base")
{
}
