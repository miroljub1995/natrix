using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ProgressProps : GlobalHtmlComponentProps<HTMLProgressElement>
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
}

public class ProgressEvents : HtmlElementComponentEvents<HTMLProgressElement>
{
}

public class Progress() : BaseNonVoidDomComponent<HTMLProgressElement, ProgressProps, ProgressEvents>("progress")
{
}
