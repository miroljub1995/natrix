using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ColgroupProps : GlobalHtmlComponentProps<HTMLTableColElement>
{
    private static readonly PropDescriptor<uint> s_span = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Span = s.Value
            : null,
        static (el, s) => el.SetUInt("span", s));

    public IReadOnlySignal<uint>? Span
    {
        get => Get(s_span);
        init => Set(s_span, value);
    }
}

public class ColgroupEvents : HtmlElementComponentEvents<HTMLTableColElement>
{
}

public class Colgroup() : BaseNonVoidDomComponent<HTMLTableColElement, ColgroupProps, ColgroupEvents>("colgroup")
{
}
