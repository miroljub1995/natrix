using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class LabelProps : GlobalHtmlComponentProps<HTMLLabelElement>
{
    private static readonly PropDescriptor<string> s_htmlFor = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.HtmlFor = s.Value
            : null,
        static (el, s) => el.SetAttribute("for", s));

    public IReadOnlySignal<string>? HtmlFor
    {
        get => Get(s_htmlFor);
        init => Set(s_htmlFor, value);
    }
}

public class LabelEvents : HtmlElementComponentEvents<HTMLLabelElement>
{
}

public class Label() : BaseNonVoidDomComponent<HTMLLabelElement, LabelProps, LabelEvents>("label")
{
}
