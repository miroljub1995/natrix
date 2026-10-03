using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class AudioProps : GlobalHtmlComponentProps<HTMLAudioElement>
{
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

    private static readonly PropDescriptor<bool> s_autoplay = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Autoplay = s.Value
            : null,
        static (el, s) => el.SetBoolean("autoplay", s));

    public IReadOnlySignal<bool>? Autoplay
    {
        get => Get(s_autoplay);
        init => Set(s_autoplay, value);
    }

    private static readonly PropDescriptor<bool> s_controls = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Controls = s.Value
            : null,
        static (el, s) => el.SetBoolean("controls", s));

    public IReadOnlySignal<bool>? Controls
    {
        get => Get(s_controls);
        init => Set(s_controls, value);
    }

    private static readonly PropDescriptor<bool> s_loop = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Loop = s.Value
            : null,
        static (el, s) => el.SetBoolean("loop", s));

    public IReadOnlySignal<bool>? Loop
    {
        get => Get(s_loop);
        init => Set(s_loop, value);
    }

    private static readonly PropDescriptor<bool> s_muted = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Muted = s.Value
            : null,
        static (el, s) => el.SetBoolean("muted", s));

    public IReadOnlySignal<bool>? Muted
    {
        get => Get(s_muted);
        init => Set(s_muted, value);
    }

    private static readonly PropDescriptor<string> s_preload = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Preload = s.Value
            : null,
        static (el, s) => el.SetAttribute("preload", s));

    public IReadOnlySignal<string>? Preload
    {
        get => Get(s_preload);
        init => Set(s_preload, value);
    }

    private static readonly PropDescriptor<string?> s_crossOrigin = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.CrossOrigin = s.Value
            : null,
        static (el, s) => el.SetNullableString("crossorigin", s));

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get(s_crossOrigin);
        init => Set(s_crossOrigin, value);
    }

    private static readonly PropDescriptor<bool> s_disableRemotePlayback = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.DisableRemotePlayback = s.Value
            : null,
        static (el, s) => el.SetBoolean("disableremoteplayback", s));

    public IReadOnlySignal<bool>? DisableRemotePlayback
    {
        get => Get(s_disableRemotePlayback);
        init => Set(s_disableRemotePlayback, value);
    }
}

public class AudioEvents : HtmlElementComponentEvents<HTMLAudioElement>
{
}

public class Audio() : BaseNonVoidDomComponent<HTMLAudioElement, AudioProps, AudioEvents>("audio")
{
}
