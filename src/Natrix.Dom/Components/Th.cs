using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ThProps : GlobalHtmlComponentProps<HTMLTableCellElement>
{
    private static readonly object s_colSpanKey = new();

    public IReadOnlySignal<uint>? ColSpan
    {
        get => Get<IReadOnlySignal<uint>>(s_colSpanKey);
        init => Set(
            s_colSpanKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.ColSpan = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("colspan", (IReadOnlySignal<uint>)s));
    }

    private static readonly object s_rowSpanKey = new();

    public IReadOnlySignal<uint>? RowSpan
    {
        get => Get<IReadOnlySignal<uint>>(s_rowSpanKey);
        init => Set(
            s_rowSpanKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.RowSpan = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("rowspan", (IReadOnlySignal<uint>)s));
    }

    private static readonly object s_headersKey = new();

    public IReadOnlySignal<string>? Headers
    {
        get => Get<IReadOnlySignal<string>>(s_headersKey);
        init => Set(
            s_headersKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Headers = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("headers", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_scopeKey = new();

    public IReadOnlySignal<string>? Scope
    {
        get => Get<IReadOnlySignal<string>>(s_scopeKey);
        init => Set(
            s_scopeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Scope = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("scope", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_abbrKey = new();

    public IReadOnlySignal<string>? Abbr
    {
        get => Get<IReadOnlySignal<string>>(s_abbrKey);
        init => Set(
            s_abbrKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Abbr = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("abbr", (IReadOnlySignal<string>)s));
    }
}

public class ThEvents : HtmlElementComponentEvents<HTMLTableCellElement>
{
}

public class Th() : BaseNonVoidDomComponent<HTMLTableCellElement, ThProps, ThEvents>("th")
{
}
