using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class MeterProps : GlobalHtmlComponentProps<HTMLMeterElement>
{
    private static readonly PropDescriptor<double> s_value = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Value = s.Value;
        },
        static (el, s) => el.SetDouble("value", s));

    public IReadOnlySignal<double>? Value
    {
        get => Get(s_value);
        init => Set(s_value, value);
    }

    private static readonly PropDescriptor<double> s_min = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Min = s.Value;
        },
        static (el, s) => el.SetDouble("min", s));

    public IReadOnlySignal<double>? Min
    {
        get => Get(s_min);
        init => Set(s_min, value);
    }

    private static readonly PropDescriptor<double> s_max = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Max = s.Value;
        },
        static (el, s) => el.SetDouble("max", s));

    public IReadOnlySignal<double>? Max
    {
        get => Get(s_max);
        init => Set(s_max, value);
    }

    private static readonly PropDescriptor<double> s_low = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Low = s.Value;
        },
        static (el, s) => el.SetDouble("low", s));

    public IReadOnlySignal<double>? Low
    {
        get => Get(s_low);
        init => Set(s_low, value);
    }

    private static readonly PropDescriptor<double> s_high = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.High = s.Value;
        },
        static (el, s) => el.SetDouble("high", s));

    public IReadOnlySignal<double>? High
    {
        get => Get(s_high);
        init => Set(s_high, value);
    }

    private static readonly PropDescriptor<double> s_optimum = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Optimum = s.Value;
        },
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
