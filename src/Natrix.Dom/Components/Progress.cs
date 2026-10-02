using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ProgressProps : GlobalHtmlComponentProps<HTMLProgressElement>
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
}

public class ProgressEvents : HtmlElementComponentEvents<HTMLProgressElement>
{
}

public class Progress() : BaseNonVoidDomComponent<HTMLProgressElement, ProgressProps, ProgressEvents>("progress")
{
}
