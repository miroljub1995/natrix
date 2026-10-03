using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class OlProps : GlobalHtmlComponentProps<HTMLOListElement>
{
    private static PropDescriptor<bool>? s_reversed;

    public IReadOnlySignal<bool>? Reversed
    {
        get => Get(s_reversed);
        init => Set(ref s_reversed, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Reversed = s.Value;
            },
            static (el, s) => el.SetBoolean("reversed", s)));
    }

    private static PropDescriptor<int>? s_start;

    public IReadOnlySignal<int>? Start
    {
        get => Get(s_start);
        init => Set(ref s_start, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Start = s.Value;
            },
            static (el, s) => el.SetInt("start", s)));
    }

    private static PropDescriptor<string>? s_type;

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(ref s_type, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Type = s.Value;
            },
            static (el, s) => el.SetAttribute("type", s)));
    }
}

public class OlEvents : HtmlElementComponentEvents<HTMLOListElement>
{
}

public class Ol() : BaseNonVoidDomComponent<HTMLOListElement, OlProps, OlEvents>("ol")
{
}
