using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class VideoProps : GlobalHtmlComponentProps<HTMLVideoElement>
{
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

    private static readonly PropDescriptor<bool> s_autoplay = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Autoplay = s.Value;
        },
        static (el, s) => el.SetBoolean("autoplay", s));

    public IReadOnlySignal<bool>? Autoplay
    {
        get => Get(s_autoplay);
        init => Set(s_autoplay, value);
    }

    private static readonly PropDescriptor<bool> s_controls = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Controls = s.Value;
        },
        static (el, s) => el.SetBoolean("controls", s));

    public IReadOnlySignal<bool>? Controls
    {
        get => Get(s_controls);
        init => Set(s_controls, value);
    }

    private static readonly PropDescriptor<bool> s_loop = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Loop = s.Value;
        },
        static (el, s) => el.SetBoolean("loop", s));

    public IReadOnlySignal<bool>? Loop
    {
        get => Get(s_loop);
        init => Set(s_loop, value);
    }

    private static readonly PropDescriptor<bool> s_muted = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Muted = s.Value;
        },
        static (el, s) => el.SetBoolean("muted", s));

    public IReadOnlySignal<bool>? Muted
    {
        get => Get(s_muted);
        init => Set(s_muted, value);
    }

    private static readonly PropDescriptor<string> s_preload = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Preload = s.Value;
        },
        static (el, s) => el.SetAttribute("preload", s));

    public IReadOnlySignal<string>? Preload
    {
        get => Get(s_preload);
        init => Set(s_preload, value);
    }

    private static readonly PropDescriptor<string?> s_crossOrigin = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.CrossOrigin = s.Value;
        },
        static (el, s) => el.SetNullableString("crossorigin", s));

    public IReadOnlySignal<string?>? CrossOrigin
    {
        get => Get(s_crossOrigin);
        init => Set(s_crossOrigin, value);
    }

    private static readonly PropDescriptor<string> s_poster = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Poster = s.Value;
        },
        static (el, s) => el.SetAttribute("poster", s));

    public IReadOnlySignal<string>? Poster
    {
        get => Get(s_poster);
        init => Set(s_poster, value);
    }

    private static readonly PropDescriptor<bool> s_playsInline = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.PlaysInline = s.Value;
        },
        static (el, s) => el.SetBoolean("playsinline", s));

    public IReadOnlySignal<bool>? PlaysInline
    {
        get => Get(s_playsInline);
        init => Set(s_playsInline, value);
    }

    private static readonly PropDescriptor<uint> s_width = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Width = s.Value;
        },
        static (el, s) => el.SetUInt("width", s));

    public IReadOnlySignal<uint>? Width
    {
        get => Get(s_width);
        init => Set(s_width, value);
    }

    private static readonly PropDescriptor<uint> s_height = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Height = s.Value;
        },
        static (el, s) => el.SetUInt("height", s));

    public IReadOnlySignal<uint>? Height
    {
        get => Get(s_height);
        init => Set(s_height, value);
    }

    private static readonly PropDescriptor<bool> s_disablePictureInPicture = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.DisablePictureInPicture = s.Value;
        },
        static (el, s) => el.SetBoolean("disablepictureinpicture", s));

    public IReadOnlySignal<bool>? DisablePictureInPicture
    {
        get => Get(s_disablePictureInPicture);
        init => Set(s_disablePictureInPicture, value);
    }

    private static readonly PropDescriptor<bool> s_disableRemotePlayback = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.DisableRemotePlayback = s.Value;
        },
        static (el, s) => el.SetBoolean("disableremoteplayback", s));

    public IReadOnlySignal<bool>? DisableRemotePlayback
    {
        get => Get(s_disableRemotePlayback);
        init => Set(s_disableRemotePlayback, value);
    }
}

public class VideoEvents : HtmlElementComponentEvents<HTMLVideoElement>
{
}

public class Video() : BaseNonVoidDomComponent<HTMLVideoElement, VideoProps, VideoEvents>("video")
{
}
