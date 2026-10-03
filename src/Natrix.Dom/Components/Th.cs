using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ThProps : GlobalHtmlComponentProps<HTMLTableCellElement>
{
    private static readonly PropDescriptor<uint> s_colSpan = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.ColSpan = s.Value
            : null,
        static (el, s) => el.SetUInt("colspan", s));

    public IReadOnlySignal<uint>? ColSpan
    {
        get => Get(s_colSpan);
        init => Set(s_colSpan, value);
    }

    private static readonly PropDescriptor<uint> s_rowSpan = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.RowSpan = s.Value
            : null,
        static (el, s) => el.SetUInt("rowspan", s));

    public IReadOnlySignal<uint>? RowSpan
    {
        get => Get(s_rowSpan);
        init => Set(s_rowSpan, value);
    }

    private static readonly PropDescriptor<string> s_headers = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Headers = s.Value
            : null,
        static (el, s) => el.SetAttribute("headers", s));

    public IReadOnlySignal<string>? Headers
    {
        get => Get(s_headers);
        init => Set(s_headers, value);
    }

    private static readonly PropDescriptor<string> s_scope = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Scope = s.Value
            : null,
        static (el, s) => el.SetAttribute("scope", s));

    public IReadOnlySignal<string>? Scope
    {
        get => Get(s_scope);
        init => Set(s_scope, value);
    }

    private static readonly PropDescriptor<string> s_abbr = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Abbr = s.Value
            : null,
        static (el, s) => el.SetAttribute("abbr", s));

    public IReadOnlySignal<string>? Abbr
    {
        get => Get(s_abbr);
        init => Set(s_abbr, value);
    }
}

public class ThEvents : HtmlElementComponentEvents<HTMLTableCellElement>
{
}

public class Th() : BaseNonVoidDomComponent<HTMLTableCellElement, ThProps, ThEvents>("th")
{
}
