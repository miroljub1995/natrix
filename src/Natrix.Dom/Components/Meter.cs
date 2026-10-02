using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class MeterProps : GlobalHtmlComponentProps<HTMLMeterElement>
{
    private static readonly object s_valueKey = new();

    public IReadOnlySignal<double>? Value
    {
        get => Get<IReadOnlySignal<double>>(s_valueKey);
        init => Set(
            s_valueKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Value = ((IReadOnlySignal<double>)s).Value
                : null,
            static (el, s) => el.SetDouble("value", (IReadOnlySignal<double>)s));
    }

    private static readonly object s_minKey = new();

    public IReadOnlySignal<double>? Min
    {
        get => Get<IReadOnlySignal<double>>(s_minKey);
        init => Set(
            s_minKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Min = ((IReadOnlySignal<double>)s).Value
                : null,
            static (el, s) => el.SetDouble("min", (IReadOnlySignal<double>)s));
    }

    private static readonly object s_maxKey = new();

    public IReadOnlySignal<double>? Max
    {
        get => Get<IReadOnlySignal<double>>(s_maxKey);
        init => Set(
            s_maxKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Max = ((IReadOnlySignal<double>)s).Value
                : null,
            static (el, s) => el.SetDouble("max", (IReadOnlySignal<double>)s));
    }

    private static readonly object s_lowKey = new();

    public IReadOnlySignal<double>? Low
    {
        get => Get<IReadOnlySignal<double>>(s_lowKey);
        init => Set(
            s_lowKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Low = ((IReadOnlySignal<double>)s).Value
                : null,
            static (el, s) => el.SetDouble("low", (IReadOnlySignal<double>)s));
    }

    private static readonly object s_highKey = new();

    public IReadOnlySignal<double>? High
    {
        get => Get<IReadOnlySignal<double>>(s_highKey);
        init => Set(
            s_highKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.High = ((IReadOnlySignal<double>)s).Value
                : null,
            static (el, s) => el.SetDouble("high", (IReadOnlySignal<double>)s));
    }

    private static readonly object s_optimumKey = new();

    public IReadOnlySignal<double>? Optimum
    {
        get => Get<IReadOnlySignal<double>>(s_optimumKey);
        init => Set(
            s_optimumKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Optimum = ((IReadOnlySignal<double>)s).Value
                : null,
            static (el, s) => el.SetDouble("optimum", (IReadOnlySignal<double>)s));
    }
}

public class MeterEvents : HtmlElementComponentEvents<HTMLMeterElement>
{
}

public class Meter() : BaseNonVoidDomComponent<HTMLMeterElement, MeterProps, MeterEvents>("meter")
{
}
