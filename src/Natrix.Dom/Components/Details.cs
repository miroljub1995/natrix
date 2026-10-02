using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class DetailsProps : GlobalHtmlComponentProps<HTMLDetailsElement>
{
    private static readonly object s_nameKey = new();

    public IReadOnlySignal<string>? Name
    {
        get => Get<IReadOnlySignal<string>>(s_nameKey);
        init => Set(
            s_nameKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Name = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("name", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_openKey = new();

    public IReadOnlySignal<bool>? Open
    {
        get => Get<IReadOnlySignal<bool>>(s_openKey);
        init => Set(
            s_openKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Open = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("open", (IReadOnlySignal<bool>)s));
    }
}

public class DetailsEvents : HtmlElementComponentEvents<HTMLDetailsElement>
{
}

public class Details() : BaseNonVoidDomComponent<HTMLDetailsElement, DetailsProps, DetailsEvents>("details")
{
}
