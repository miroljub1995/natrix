using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ColgroupProps : GlobalHtmlComponentProps<HTMLTableColElement>
{
    private static readonly PropDescriptor<uint> s_span = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Span = s.Value;
        },
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
