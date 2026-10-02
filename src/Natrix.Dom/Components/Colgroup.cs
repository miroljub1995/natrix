using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ColgroupProps : GlobalHtmlComponentProps<HTMLTableColElement>
{
    private static readonly object s_spanKey = new();

    public IReadOnlySignal<uint>? Span
    {
        get => Get<IReadOnlySignal<uint>>(s_spanKey);
        init => Set(
            s_spanKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Span = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("span", (IReadOnlySignal<uint>)s));
    }
}

public class ColgroupEvents : HtmlElementComponentEvents<HTMLTableColElement>
{
}

public class Colgroup() : BaseNonVoidDomComponent<HTMLTableColElement, ColgroupProps, ColgroupEvents>("colgroup")
{
}
