using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TrackProps : GlobalHtmlComponentProps<HTMLTrackElement>
{
    private static PropDescriptor<string>? s_kind;

    public IReadOnlySignal<string>? Kind
    {
        get => Get(s_kind);
        init => Set(ref s_kind, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Kind = s.Value;
            },
            static (el, s) => el.SetAttribute("kind", s)));
    }

    private static PropDescriptor<string>? s_src;

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(ref s_src, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Src = s.Value;
            },
            static (el, s) => el.SetAttribute("src", s)));
    }

    private static PropDescriptor<string>? s_srclang;

    public IReadOnlySignal<string>? Srclang
    {
        get => Get(s_srclang);
        init => Set(ref s_srclang, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Srclang = s.Value;
            },
            static (el, s) => el.SetAttribute("srclang", s)));
    }

    private static PropDescriptor<string>? s_label;

    public IReadOnlySignal<string>? Label
    {
        get => Get(s_label);
        init => Set(ref s_label, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Label = s.Value;
            },
            static (el, s) => el.SetAttribute("label", s)));
    }

    private static PropDescriptor<bool>? s_default;

    public IReadOnlySignal<bool>? Default
    {
        get => Get(s_default);
        init => Set(ref s_default, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Default = s.Value;
            },
            static (el, s) => el.SetBoolean("default", s)));
    }
}

public class TrackEvents : HtmlElementComponentEvents<HTMLTrackElement>
{
}

public class Track() : BaseVoidDomComponent<HTMLTrackElement, TrackProps, TrackEvents>("track")
{
}
