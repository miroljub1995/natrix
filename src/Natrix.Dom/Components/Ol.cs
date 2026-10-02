using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class OlProps : GlobalHtmlComponentProps<HTMLOListElement>
{
    private static readonly object s_reversedKey = new();

    public IReadOnlySignal<bool>? Reversed
    {
        get => Get<IReadOnlySignal<bool>>(s_reversedKey);
        init => Set(
            s_reversedKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Reversed = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("reversed", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_startKey = new();

    public IReadOnlySignal<int>? Start
    {
        get => Get<IReadOnlySignal<int>>(s_startKey);
        init => Set(
            s_startKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Start = ((IReadOnlySignal<int>)s).Value
                : null,
            static (el, s) => el.SetInt("start", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_typeKey = new();

    public IReadOnlySignal<string>? Type
    {
        get => Get<IReadOnlySignal<string>>(s_typeKey);
        init => Set(
            s_typeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Type = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("type", (IReadOnlySignal<string>)s));
    }
}

public class OlEvents : HtmlElementComponentEvents<HTMLOListElement>
{
}

public class Ol() : BaseNonVoidDomComponent<HTMLOListElement, OlProps, OlEvents>("ol")
{
}
