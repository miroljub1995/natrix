using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class OlProps : GlobalHtmlComponentProps<HTMLOListElement>
{
    private static readonly PropDescriptor<bool> s_reversed = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Reversed = s.Value
            : null,
        static (el, s) => el.SetBoolean("reversed", s));

    public IReadOnlySignal<bool>? Reversed
    {
        get => Get(s_reversed);
        init => Set(s_reversed, value);
    }

    private static readonly PropDescriptor<int> s_start = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Start = s.Value
            : null,
        static (el, s) => el.SetInt("start", s));

    public IReadOnlySignal<int>? Start
    {
        get => Get(s_start);
        init => Set(s_start, value);
    }

    private static readonly PropDescriptor<string> s_type = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Type = s.Value
            : null,
        static (el, s) => el.SetAttribute("type", s));

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(s_type, value);
    }
}

public class OlEvents : HtmlElementComponentEvents<HTMLOListElement>
{
}

public class Ol() : BaseNonVoidDomComponent<HTMLOListElement, OlProps, OlEvents>("ol")
{
}
