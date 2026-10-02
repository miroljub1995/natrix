using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class TrackProps : GlobalHtmlComponentProps<HTMLTrackElement>
{
    private static readonly object s_kindKey = new();

    public IReadOnlySignal<string>? Kind
    {
        get => Get<IReadOnlySignal<string>>(s_kindKey);
        init => Set(
            s_kindKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Kind = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("kind", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_srcKey = new();

    public IReadOnlySignal<string>? Src
    {
        get => Get<IReadOnlySignal<string>>(s_srcKey);
        init => Set(
            s_srcKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Src = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("src", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_srclangKey = new();

    public IReadOnlySignal<string>? Srclang
    {
        get => Get<IReadOnlySignal<string>>(s_srclangKey);
        init => Set(
            s_srclangKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Srclang = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("srclang", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_labelKey = new();

    public IReadOnlySignal<string>? Label
    {
        get => Get<IReadOnlySignal<string>>(s_labelKey);
        init => Set(
            s_labelKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Label = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("label", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_defaultKey = new();

    public IReadOnlySignal<bool>? Default
    {
        get => Get<IReadOnlySignal<bool>>(s_defaultKey);
        init => Set(
            s_defaultKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Default = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("default", (IReadOnlySignal<bool>)s));
    }
}

public class TrackEvents : HtmlElementComponentEvents<HTMLTrackElement>
{
}

public class Track() : BaseVoidDomComponent<HTMLTrackElement, TrackProps, TrackEvents>("track")
{
}
