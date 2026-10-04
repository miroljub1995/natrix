using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class FieldSetProps : GlobalHtmlComponentProps<HTMLFieldSetElement>
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

    private static PropDescriptor<string>? s_name;

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(ref s_name, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Name = s.Value;
            },
            static (el, s) => el.SetAttribute("name", s)));
    }
}

public class FieldSetEvents : HtmlElementComponentEvents<HTMLFieldSetElement>
{
}

public class FieldSet() : BaseNonVoidDomComponent<HTMLFieldSetElement, FieldSetProps, FieldSetEvents>("fieldset")
{
}
