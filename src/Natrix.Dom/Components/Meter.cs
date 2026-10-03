using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class MeterProps : GlobalHtmlComponentProps<HTMLMeterElement>
{
    private static readonly PropDescriptor<double> s_value = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Value = s.Value
            : null,
        static (el, s) => el.SetDouble("value", s));

    public IReadOnlySignal<double>? Value
    {
        get => Get(s_value);
        init => Set(s_value, value);
    }

    private static readonly PropDescriptor<double> s_min = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Min = s.Value
            : null,
        static (el, s) => el.SetDouble("min", s));

    public IReadOnlySignal<double>? Min
    {
        get => Get(s_min);
        init => Set(s_min, value);
    }

    private static readonly PropDescriptor<double> s_max = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Max = s.Value
            : null,
        static (el, s) => el.SetDouble("max", s));

    public IReadOnlySignal<double>? Max
    {
        get => Get(s_max);
        init => Set(s_max, value);
    }

    private static readonly PropDescriptor<double> s_low = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Low = s.Value
            : null,
        static (el, s) => el.SetDouble("low", s));

    public IReadOnlySignal<double>? Low
    {
        get => Get(s_low);
        init => Set(s_low, value);
    }

    private static readonly PropDescriptor<double> s_high = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.High = s.Value
            : null,
        static (el, s) => el.SetDouble("high", s));

    public IReadOnlySignal<double>? High
    {
        get => Get(s_high);
        init => Set(s_high, value);
    }

    private static readonly PropDescriptor<double> s_optimum = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Optimum = s.Value
            : null,
        static (el, s) => el.SetDouble("optimum", s));

    public IReadOnlySignal<double>? Optimum
    {
        get => Get(s_optimum);
        init => Set(s_optimum, value);
    }
}

public class MeterEvents : HtmlElementComponentEvents<HTMLMeterElement>
{
}

public class Meter() : BaseNonVoidDomComponent<HTMLMeterElement, MeterProps, MeterEvents>("meter")
{
}
