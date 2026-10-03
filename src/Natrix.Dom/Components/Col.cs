using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ColProps : GlobalHtmlComponentProps<HTMLTableColElement>
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

public class ColEvents : HtmlElementComponentEvents<HTMLTableColElement>
{
}

public class Col() : BaseVoidDomComponent<HTMLTableColElement, ColProps, ColEvents>("col")
{
}
