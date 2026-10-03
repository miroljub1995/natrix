using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class AudioProps : GlobalHtmlComponentProps<HTMLAudioElement>
{
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

    private static PropDescriptor<bool>? s_autoplay;

    public IReadOnlySignal<bool>? Autoplay
    {
        get => Get(s_autoplay);
        init => Set(ref s_autoplay, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Autoplay = s.Value;
            },
            static (el, s) => el.SetBoolean("autoplay", s)));
    }

    private static PropDescriptor<bool>? s_controls;

    public IReadOnlySignal<bool>? Controls
    {
        get => Get(s_controls);
        init => Set(ref s_controls, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Controls = s.Value;
            },
            static (el, s) => el.SetBoolean("controls", s)));
    }

    private static PropDescriptor<bool>? s_loop;

    public IReadOnlySignal<bool>? Loop
    {
        get => Get(s_loop);
        init => Set(ref s_loop, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Loop = s.Value;
            },
            static (el, s) => el.SetBoolean("loop", s)));
    }

    private static PropDescriptor<bool>? s_muted;

    public IReadOnlySignal<bool>? Muted
    {
        get => Get(s_muted);
        init => Set(ref s_muted, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Muted = s.Value;
            },
            static (el, s) => el.SetBoolean("muted", s)));
    }

    private static PropDescriptor<string>? s_preload;

    public IReadOnlySignal<string>? Preload
    {
        get => Get(s_preload);
        init => Set(ref s_preload, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Preload = s.Value;
            },
            static (el, s) => el.SetAttribute("preload", s)));
    }

    private static PropDescriptor<string?>? s_crossOrigin;

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get(s_crossOrigin);
        init => Set(ref s_crossOrigin, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.CrossOrigin = s.Value;
            },
            static (el, s) => el.SetNullableString("crossorigin", s)));
    }

    private static PropDescriptor<bool>? s_disableRemotePlayback;

    public IReadOnlySignal<bool>? DisableRemotePlayback
    {
        get => Get(s_disableRemotePlayback);
        init => Set(ref s_disableRemotePlayback, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.DisableRemotePlayback = s.Value;
            },
            static (el, s) => el.SetBoolean("disableremoteplayback", s)));
    }
}

public class AudioEvents : HtmlElementComponentEvents<HTMLAudioElement>
{
}

public class Audio() : BaseNonVoidDomComponent<HTMLAudioElement, AudioProps, AudioEvents>("audio")
{
}
