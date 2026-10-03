using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ProgressProps : GlobalHtmlComponentProps<HTMLProgressElement>
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
}

public class ProgressEvents : HtmlElementComponentEvents<HTMLProgressElement>
{
}

public class Progress() : BaseNonVoidDomComponent<HTMLProgressElement, ProgressProps, ProgressEvents>("progress")
{
}
