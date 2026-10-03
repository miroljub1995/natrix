using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class MeterProps : GlobalHtmlComponentProps<HTMLMeterElement>
{
    private static PropDescriptor<double>? s_value;

    public IReadOnlySignal<double>? Value
    {
        get => Get(s_value);
        init => Set(ref s_value, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Value = s.Value;
            },
            static (el, s) => el.SetDouble("value", s)));
    }

    private static PropDescriptor<double>? s_min;

    public IReadOnlySignal<double>? Min
    {
        get => Get(s_min);
        init => Set(ref s_min, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Min = s.Value;
            },
            static (el, s) => el.SetDouble("min", s)));
    }

    private static PropDescriptor<double>? s_max;

    public IReadOnlySignal<double>? Max
    {
        get => Get(s_max);
        init => Set(ref s_max, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Max = s.Value;
            },
            static (el, s) => el.SetDouble("max", s)));
    }

    private static PropDescriptor<double>? s_low;

    public IReadOnlySignal<double>? Low
    {
        get => Get(s_low);
        init => Set(ref s_low, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Low = s.Value;
            },
            static (el, s) => el.SetDouble("low", s)));
    }

    private static PropDescriptor<double>? s_high;

    public IReadOnlySignal<double>? High
    {
        get => Get(s_high);
        init => Set(ref s_high, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.High = s.Value;
            },
            static (el, s) => el.SetDouble("high", s)));
    }

    private static PropDescriptor<double>? s_optimum;

    public IReadOnlySignal<double>? Optimum
    {
        get => Get(s_optimum);
        init => Set(ref s_optimum, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Optimum = s.Value;
            },
            static (el, s) => el.SetDouble("optimum", s)));
    }
}

public class MeterEvents : HtmlElementComponentEvents<HTMLMeterElement>
{
}

public class Meter() : BaseNonVoidDomComponent<HTMLMeterElement, MeterProps, MeterEvents>("meter")
{
}
