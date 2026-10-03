using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DataProps : GlobalHtmlComponentProps<HTMLDataElement>
{
    private static readonly PropDescriptor<string> s_value = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Value = s.Value;
        },
        static (el, s) => el.SetAttribute("value", s));

    public IReadOnlySignal<string>? Value
    {
        get => Get(s_value);
        init => Set(s_value, value);
    }
}

public class DataEvents : HtmlElementComponentEvents<HTMLDataElement>
{
}

public class Data() : BaseNonVoidDomComponent<HTMLDataElement, DataProps, DataEvents>("data")
{
}
