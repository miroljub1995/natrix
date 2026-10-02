using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class LiProps : GlobalHtmlComponentProps<HTMLLIElement>
{
    private static readonly object s_valueKey = new();

    public IReadOnlySignal<int>? Value
    {
        get => Get<IReadOnlySignal<int>>(s_valueKey);
        init => Set(
            s_valueKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Value = ((IReadOnlySignal<int>)s).Value
                : null,
            static (el, s) => el.SetInt("value", (IReadOnlySignal<int>)s));
    }
}

public class LiEvents : HtmlElementComponentEvents<HTMLLIElement>
{
}

public class Li() : BaseNonVoidDomComponent<HTMLLIElement, LiProps, LiEvents>("li")
{
}
