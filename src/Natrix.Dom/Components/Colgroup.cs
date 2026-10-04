using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ColgroupProps : GlobalHtmlComponentProps<HTMLTableColElement>
{
    private static PropDescriptor<uint>? s_span;

    public IReadOnlySignal<uint>? Span
    {
        get => Get(s_span);
        init => Set(ref s_span, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Span = s.Value;
            },
            static (el, s) => el.SetUInt("span", s)));
    }
}

public class ColgroupEvents : HtmlElementComponentEvents<HTMLTableColElement>
{
}

public class Colgroup() : BaseNonVoidDomComponent<HTMLTableColElement, ColgroupProps, ColgroupEvents>("colgroup")
{
}
