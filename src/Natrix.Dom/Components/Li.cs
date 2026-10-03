using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class LiProps : GlobalHtmlComponentProps<HTMLLIElement>
{
    private static readonly PropDescriptor<int> s_value = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Value = s.Value
            : null,
        static (el, s) => el.SetInt("value", s));

    public IReadOnlySignal<int>? Value
    {
        get => Get(s_value);
        init => Set(s_value, value);
    }
}

public class LiEvents : HtmlElementComponentEvents<HTMLLIElement>
{
}

public class Li() : BaseNonVoidDomComponent<HTMLLIElement, LiProps, LiEvents>("li")
{
}
