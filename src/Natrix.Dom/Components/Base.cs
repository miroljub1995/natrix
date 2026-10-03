using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class BaseProps : GlobalHtmlComponentProps<HTMLBaseElement>
{
    private static readonly PropDescriptor<string> s_href = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Href = s.Value;
        },
        static (el, s) => el.SetAttribute("href", s));

    public IReadOnlySignal<string>? Href
    {
        get => Get(s_href);
        init => Set(s_href, value);
    }

    private static readonly PropDescriptor<string> s_target = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Target = s.Value;
        },
        static (el, s) => el.SetAttribute("target", s));

    public IReadOnlySignal<string>? Target
    {
        get => Get(s_target);
        init => Set(s_target, value);
    }
}

public class BaseEvents : HtmlElementComponentEvents<HTMLBaseElement>
{
}

public class Base() : BaseVoidDomComponent<HTMLBaseElement, BaseProps, BaseEvents>("base")
{
}
