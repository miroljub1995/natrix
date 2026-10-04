using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class OptGroupProps : GlobalHtmlComponentProps<HTMLOptGroupElement>
{
    private static PropDescriptor<bool>? s_disabled;

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get(s_disabled);
        init => Set(ref s_disabled, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Disabled = s.Value;
            },
            static (el, s) => el.SetBoolean("disabled", s)));
    }

    private static PropDescriptor<string>? s_label;

    public IReadOnlySignal<string>? Label
    {
        get => Get(s_label);
        init => Set(ref s_label, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Label = s.Value;
            },
            static (el, s) => el.SetAttribute("label", s)));
    }
}

public class OptGroupEvents : HtmlElementComponentEvents<HTMLOptGroupElement>
{
}

public class OptGroup() : BaseNonVoidDomComponent<HTMLOptGroupElement, OptGroupProps, OptGroupEvents>("optgroup")
{
}
