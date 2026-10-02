using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class BaseProps : GlobalHtmlComponentProps<HTMLBaseElement>
{
    private static readonly object s_hrefKey = new();

    public IReadOnlySignal<string>? Href
    {
        get => Get<IReadOnlySignal<string>>(s_hrefKey);
        init => Set(
            s_hrefKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Href = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("href", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_targetKey = new();

    public IReadOnlySignal<string>? Target
    {
        get => Get<IReadOnlySignal<string>>(s_targetKey);
        init => Set(
            s_targetKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Target = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("target", (IReadOnlySignal<string>)s));
    }
}

public class BaseEvents : HtmlElementComponentEvents<HTMLBaseElement>
{
}

public class Base() : BaseVoidDomComponent<HTMLBaseElement, BaseProps, BaseEvents>("base")
{
}
