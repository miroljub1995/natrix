using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class OlProps : GlobalHtmlComponentProps<HTMLOListElement>
{
    private static readonly PropDescriptor<bool> s_reversed = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Reversed = s.Value;
        },
        static (el, s) => el.SetBoolean("reversed", s));

    public IReadOnlySignal<bool>? Reversed
    {
        get => Get(s_reversed);
        init => Set(s_reversed, value);
    }

    private static readonly PropDescriptor<int> s_start = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Start = s.Value;
        },
        static (el, s) => el.SetInt("start", s));

    public IReadOnlySignal<int>? Start
    {
        get => Get(s_start);
        init => Set(s_start, value);
    }

    private static readonly PropDescriptor<string> s_type = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Type = s.Value;
        },
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
