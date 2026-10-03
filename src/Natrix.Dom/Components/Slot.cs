using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class SlotProps : GlobalHtmlComponentProps<HTMLSlotElement>
{
    private static readonly PropDescriptor<string> s_name = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Name = s.Value
            : null,
        static (el, s) => el.SetAttribute("name", s));

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(s_name, value);
    }
}

public class SlotEvents : HtmlElementComponentEvents<HTMLSlotElement>
{
}

public class Slot() : BaseNonVoidDomComponent<HTMLSlotElement, SlotProps, SlotEvents>("slot")
{
}
