using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class DialogProps : GlobalHtmlComponentProps<HTMLDialogElement>
{
    private static readonly PropDescriptor<bool> s_open = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Open = s.Value
            : null,
        static (el, s) => el.SetBoolean("open", s));

    public IReadOnlySignal<bool>? Open
    {
        get => Get(s_open);
        init => Set(s_open, value);
    }
}

public class DialogEvents : HtmlElementComponentEvents<HTMLDialogElement>
{
}

public class Dialog() : BaseNonVoidDomComponent<HTMLDialogElement, DialogProps, DialogEvents>("dialog")
{
}
