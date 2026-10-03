using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ThProps : GlobalHtmlComponentProps<HTMLTableCellElement>
{
    private static PropDescriptor<uint>? s_colSpan;

    public IReadOnlySignal<uint>? ColSpan
    {
        get => Get(s_colSpan);
        init => Set(ref s_colSpan, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.ColSpan = s.Value;
            },
            static (el, s) => el.SetUInt("colspan", s)));
    }

    private static PropDescriptor<uint>? s_rowSpan;

    public IReadOnlySignal<uint>? RowSpan
    {
        get => Get(s_rowSpan);
        init => Set(ref s_rowSpan, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.RowSpan = s.Value;
            },
            static (el, s) => el.SetUInt("rowspan", s)));
    }

    private static PropDescriptor<string>? s_headers;

    public IReadOnlySignal<string>? Headers
    {
        get => Get(s_headers);
        init => Set(ref s_headers, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Headers = s.Value;
            },
            static (el, s) => el.SetAttribute("headers", s)));
    }

    private static PropDescriptor<string>? s_scope;

    public IReadOnlySignal<string>? Scope
    {
        get => Get(s_scope);
        init => Set(ref s_scope, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Scope = s.Value;
            },
            static (el, s) => el.SetAttribute("scope", s)));
    }

    private static PropDescriptor<string>? s_abbr;

    public IReadOnlySignal<string>? Abbr
    {
        get => Get(s_abbr);
        init => Set(ref s_abbr, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Abbr = s.Value;
            },
            static (el, s) => el.SetAttribute("abbr", s)));
    }
}

public class ThEvents : HtmlElementComponentEvents<HTMLTableCellElement>
{
}

public class Th() : BaseNonVoidDomComponent<HTMLTableCellElement, ThProps, ThEvents>("th")
{
}
