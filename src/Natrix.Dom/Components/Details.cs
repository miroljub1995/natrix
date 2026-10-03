using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DetailsProps : GlobalHtmlComponentProps<HTMLDetailsElement>
{
    private static readonly PropDescriptor<string> s_name = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Name = s.Value;
        },
        static (el, s) => el.SetAttribute("name", s));

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(s_name, value);
    }

    private static readonly PropDescriptor<bool> s_open = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Open = s.Value;
        },
        static (el, s) => el.SetBoolean("open", s));

    public IReadOnlySignal<bool>? Open
    {
        get => Get(s_open);
        init => Set(s_open, value);
    }
}

public class DetailsEvents : HtmlElementComponentEvents<HTMLDetailsElement>
{
}

public class Details() : BaseNonVoidDomComponent<HTMLDetailsElement, DetailsProps, DetailsEvents>("details")
{
}
