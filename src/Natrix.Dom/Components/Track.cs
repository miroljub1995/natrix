using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class TrackProps : GlobalHtmlComponentProps<HTMLTrackElement>
{
    private static readonly PropDescriptor<string> s_kind = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Kind = s.Value
            : null,
        static (el, s) => el.SetAttribute("kind", s));

    public IReadOnlySignal<string>? Kind
    {
        get => Get(s_kind);
        init => Set(s_kind, value);
    }

    private static readonly PropDescriptor<string> s_src = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Src = s.Value
            : null,
        static (el, s) => el.SetAttribute("src", s));

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(s_src, value);
    }

    private static readonly PropDescriptor<string> s_srclang = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Srclang = s.Value
            : null,
        static (el, s) => el.SetAttribute("srclang", s));

    public IReadOnlySignal<string>? Srclang
    {
        get => Get(s_srclang);
        init => Set(s_srclang, value);
    }

    private static readonly PropDescriptor<string> s_label = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Label = s.Value
            : null,
        static (el, s) => el.SetAttribute("label", s));

    public IReadOnlySignal<string>? Label
    {
        get => Get(s_label);
        init => Set(s_label, value);
    }

    private static readonly PropDescriptor<bool> s_default = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Default = s.Value
            : null,
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
