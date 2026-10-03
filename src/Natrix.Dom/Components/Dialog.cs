using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DialogProps : GlobalHtmlComponentProps<HTMLDialogElement>
{
    private static readonly PropDescriptor<bool> s_open = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Open = s.Value;
        },
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
