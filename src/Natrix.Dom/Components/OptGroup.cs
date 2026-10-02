using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class OptGroupProps : GlobalHtmlComponentProps<HTMLOptGroupElement>
{
    private static readonly object s_disabledKey = new();

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get<IReadOnlySignal<bool>>(s_disabledKey);
        init => Set(
            s_disabledKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Disabled = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("disabled", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_labelKey = new();

    public IReadOnlySignal<string>? Label
    {
        get => Get<IReadOnlySignal<string>>(s_labelKey);
        init => Set(
            s_labelKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Label = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("label", (IReadOnlySignal<string>)s));
    }
}

public class OptGroupEvents : HtmlElementComponentEvents<HTMLOptGroupElement>
{
}

public class OptGroup() : BaseNonVoidDomComponent<HTMLOptGroupElement, OptGroupProps, OptGroupEvents>("optgroup")
{
}
