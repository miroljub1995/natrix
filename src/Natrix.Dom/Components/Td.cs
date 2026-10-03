using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TdProps : GlobalHtmlComponentProps<HTMLTableCellElement>
{
    private static readonly PropDescriptor<uint> s_colSpan = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.ColSpan = s.Value;
        },
        static (el, s) => el.SetUInt("colspan", s));

    public IReadOnlySignal<uint>? ColSpan
    {
        get => Get(s_colSpan);
        init => Set(s_colSpan, value);
    }

    private static readonly PropDescriptor<uint> s_rowSpan = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.RowSpan = s.Value;
        },
        static (el, s) => el.SetUInt("rowspan", s));

    public IReadOnlySignal<uint>? RowSpan
    {
        get => Get(s_rowSpan);
        init => Set(s_rowSpan, value);
    }

    private static readonly PropDescriptor<string> s_headers = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Headers = s.Value;
        },
        static (el, s) => el.SetAttribute("headers", s));

    public IReadOnlySignal<string>? Headers
    {
        get => Get(s_headers);
        init => Set(s_headers, value);
    }
}

public class TdEvents : HtmlElementComponentEvents<HTMLTableCellElement>
{
}

public class Td() : BaseNonVoidDomComponent<HTMLTableCellElement, TdProps, TdEvents>("td")
{
}
