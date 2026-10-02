using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class LabelProps : GlobalHtmlComponentProps<HTMLLabelElement>
{
    private static readonly object s_htmlForKey = new();

    public IReadOnlySignal<string>? HtmlFor
    {
        get => Get<IReadOnlySignal<string>>(s_htmlForKey);
        init => Set(
            s_htmlForKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.HtmlFor = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("for", (IReadOnlySignal<string>)s));
    }
}

public class LabelEvents : HtmlElementComponentEvents<HTMLLabelElement>
{
}

public class Label() : BaseNonVoidDomComponent<HTMLLabelElement, LabelProps, LabelEvents>("label")
{
}
