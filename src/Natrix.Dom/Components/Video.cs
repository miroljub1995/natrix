using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class VideoProps : GlobalHtmlComponentProps<HTMLVideoElement>
{
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

    private static readonly object s_autoplayKey = new();

    public IReadOnlySignal<bool>? Autoplay
    {
        get => Get<IReadOnlySignal<bool>>(s_autoplayKey);
        init => Set(
            s_autoplayKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Autoplay = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("autoplay", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_controlsKey = new();

    public IReadOnlySignal<bool>? Controls
    {
        get => Get<IReadOnlySignal<bool>>(s_controlsKey);
        init => Set(
            s_controlsKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Controls = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("controls", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_loopKey = new();

    public IReadOnlySignal<bool>? Loop
    {
        get => Get<IReadOnlySignal<bool>>(s_loopKey);
        init => Set(
            s_loopKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Loop = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("loop", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_mutedKey = new();

    public IReadOnlySignal<bool>? Muted
    {
        get => Get<IReadOnlySignal<bool>>(s_mutedKey);
        init => Set(
            s_mutedKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Muted = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("muted", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_preloadKey = new();

    public IReadOnlySignal<string>? Preload
    {
        get => Get<IReadOnlySignal<string>>(s_preloadKey);
        init => Set(
            s_preloadKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Preload = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("preload", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_crossOriginKey = new();

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get<IReadOnlySignal<string?>>(s_crossOriginKey);
        init => Set(
            s_crossOriginKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.CrossOrigin = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("crossorigin", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_posterKey = new();

    public IReadOnlySignal<string>? Poster
    {
        get => Get<IReadOnlySignal<string>>(s_posterKey);
        init => Set(
            s_posterKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Poster = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("poster", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_playsInlineKey = new();

    public IReadOnlySignal<bool>? PlaysInline
    {
        get => Get<IReadOnlySignal<bool>>(s_playsInlineKey);
        init => Set(
            s_playsInlineKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.PlaysInline = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("playsinline", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_widthKey = new();

    public IReadOnlySignal<uint>? Width
    {
        get => Get<IReadOnlySignal<uint>>(s_widthKey);
        init => Set(
            s_widthKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Width = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("width", (IReadOnlySignal<uint>)s));
    }

    private static readonly object s_heightKey = new();

    public IReadOnlySignal<uint>? Height
    {
        get => Get<IReadOnlySignal<uint>>(s_heightKey);
        init => Set(
            s_heightKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Height = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("height", (IReadOnlySignal<uint>)s));
    }

    private static readonly object s_disablePictureInPictureKey = new();

    public IReadOnlySignal<bool>? DisablePictureInPicture
    {
        get => Get<IReadOnlySignal<bool>>(s_disablePictureInPictureKey);
        init => Set(
            s_disablePictureInPictureKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.DisablePictureInPicture = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("disablepictureinpicture", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_disableRemotePlaybackKey = new();

    public IReadOnlySignal<bool>? DisableRemotePlayback
    {
        get => Get<IReadOnlySignal<bool>>(s_disableRemotePlaybackKey);
        init => Set(
            s_disableRemotePlaybackKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.DisableRemotePlayback = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("disableremoteplayback", (IReadOnlySignal<bool>)s));
    }
}

public class VideoEvents : HtmlElementComponentEvents<HTMLVideoElement>
{
}

public class Video() : BaseNonVoidDomComponent<HTMLVideoElement, VideoProps, VideoEvents>("video")
{
}
