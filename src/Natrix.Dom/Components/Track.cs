using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TrackProps : GlobalHtmlComponentProps<HTMLTrackElement>
{
    private static readonly PropDescriptor<string> s_kind = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Kind = s.Value;
        },
        static (el, s) => el.SetAttribute("kind", s));

    public IReadOnlySignal<string>? Kind
    {
        get => Get(s_kind);
        init => Set(s_kind, value);
    }

    private static readonly PropDescriptor<string> s_src = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Src = s.Value;
        },
        static (el, s) => el.SetAttribute("src", s));

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(s_src, value);
    }

    private static readonly PropDescriptor<string> s_srclang = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Srclang = s.Value;
        },
        static (el, s) => el.SetAttribute("srclang", s));

    public IReadOnlySignal<string>? Srclang
    {
        get => Get(s_srclang);
        init => Set(s_srclang, value);
    }

    private static readonly PropDescriptor<string> s_label = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Label = s.Value;
        },
        static (el, s) => el.SetAttribute("label", s));

    public IReadOnlySignal<string>? Label
    {
        get => Get(s_label);
        init => Set(s_label, value);
    }

    private static readonly PropDescriptor<bool> s_default = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Default = s.Value;
        },
        static (el, s) => el.SetBoolean("default", s));

    public IReadOnlySignal<bool>? Default
    {
        get => Get(s_default);
        init => Set(s_default, value);
    }
}

public class TrackEvents : HtmlElementComponentEvents<HTMLTrackElement>
{
}

public class Track() : BaseVoidDomComponent<HTMLTrackElement, TrackProps, TrackEvents>("track")
{
}
