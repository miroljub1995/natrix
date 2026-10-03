using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class OptGroupProps : GlobalHtmlComponentProps<HTMLOptGroupElement>
{
    private static readonly PropDescriptor<bool> s_disabled = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Disabled = s.Value;
        },
        static (el, s) => el.SetBoolean("disabled", s));

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get(s_disabled);
        init => Set(s_disabled, value);
    }

    private static readonly PropDescriptor<string> s_label = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Label = s.Value;
        },
        static (el, s) => el.SetAttribute("label", s));

    public IReadOnlySignal<string>? Label
    {
        get => Get(s_label);
        init => Set(s_label, value);
    }
}

public class OptGroupEvents : HtmlElementComponentEvents<HTMLOptGroupElement>
{
}

public class OptGroup() : BaseNonVoidDomComponent<HTMLOptGroupElement, OptGroupProps, OptGroupEvents>("optgroup")
{
}
