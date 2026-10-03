using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class LabelProps : GlobalHtmlComponentProps<HTMLLabelElement>
{
    private static PropDescriptor<string>? s_htmlFor;

    public IReadOnlySignal<string>? HtmlFor
    {
        get => Get(s_htmlFor);
        init => Set(ref s_htmlFor, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.HtmlFor = s.Value;
            },
            static (el, s) => el.SetAttribute("for", s)));
    }
}

public class LabelEvents : HtmlElementComponentEvents<HTMLLabelElement>
{
}

public class Label() : BaseNonVoidDomComponent<HTMLLabelElement, LabelProps, LabelEvents>("label")
{
}
