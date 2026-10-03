using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DetailsProps : GlobalHtmlComponentProps<HTMLDetailsElement>
{
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

    private static PropDescriptor<bool>? s_open;

    public IReadOnlySignal<bool>? Open
    {
        get => Get(s_open);
        init => Set(ref s_open, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Open = s.Value;
            },
            static (el, s) => el.SetBoolean("open", s)));
    }
}

public class DetailsEvents : HtmlElementComponentEvents<HTMLDetailsElement>
{
}

public class Details() : BaseNonVoidDomComponent<HTMLDetailsElement, DetailsProps, DetailsEvents>("details")
{
}
