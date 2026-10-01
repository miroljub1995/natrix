// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLMediaElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLMediaElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLMediaElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLMediaElement global::Natrix.JSCore.IJSObjectProxy<HTMLMediaElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLMediaElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SinkId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sinkId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise SetSinkId(string sinkId)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = sinkId;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "setSinkId", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaKeys? MediaKeys
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.MediaKeys>.Get(JSObject, "mediaKeys");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onencrypted
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onencrypted");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onencrypted", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onwaitingforkey
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onwaitingforkey");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onwaitingforkey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise SetMediaKeys(global::Natrix.StdWeb.MediaKeys? mediaKeys)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_3;
        if (mediaKeys is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaKeys ___notNullable_4 = (global::Natrix.StdWeb.MediaKeys)mediaKeys;
            ___marshalledValue_3 = ___notNullable_4.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "setMediaKeys", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaError? Error
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.MediaError>.Get(JSObject, "error");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "src");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "src", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStream>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSource>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>>? SrcObject
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStream>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSource>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>>>.Get(JSObject, "srcObject");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStream>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSource>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>>>.Set(JSObject, "srcObject", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CurrentSrc
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "currentSrc");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? CrossOrigin
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "crossOrigin");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "crossOrigin", value);
    }

    public const ushort NETWORK_EMPTY = 0;

    public const ushort NETWORK_IDLE = 1;

    public const ushort NETWORK_LOADING = 2;

    public const ushort NETWORK_NO_SOURCE = 3;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort NetworkState
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "networkState");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Preload
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "preload");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "preload", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TimeRanges Buffered
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimeRanges>.Get(JSObject, "buffered");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Load()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "load", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CanPlayTypeResult CanPlayType(string type)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "canPlayType", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CanPlayTypeResult>.Get(___resOwner_1.JSObject, "value");
    }

    public const ushort HAVE_NOTHING = 0;

    public const ushort HAVE_METADATA = 1;

    public const ushort HAVE_CURRENT_DATA = 2;

    public const ushort HAVE_FUTURE_DATA = 3;

    public const ushort HAVE_ENOUGH_DATA = 4;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ReadyState
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "readyState");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Seeking
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "seeking");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CurrentTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "currentTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "currentTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void FastSeek(double time)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = time;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "fastSeek", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Duration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "duration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject GetStartDate()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getStartDate", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Paused
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "paused");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DefaultPlaybackRate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "defaultPlaybackRate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "defaultPlaybackRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PlaybackRate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "playbackRate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "playbackRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PreservesPitch
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "preservesPitch");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "preservesPitch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TimeRanges Played
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimeRanges>.Get(JSObject, "played");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TimeRanges Seekable
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimeRanges>.Get(JSObject, "seekable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Ended
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ended");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Autoplay
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "autoplay");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "autoplay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Loop
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "loop");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "loop", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Play()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "play", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Pause()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "pause", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Controls
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "controls");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "controls", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Volume
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "volume");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "volume", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Muted
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "muted");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "muted", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DefaultMuted
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "defaultMuted");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "defaultMuted", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Loading
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "loading");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "loading", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioTrackList AudioTracks
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioTrackList>.Get(JSObject, "audioTracks");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoTrackList VideoTracks
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoTrackList>.Get(JSObject, "videoTracks");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TextTrackList TextTracks
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextTrackList>.Get(JSObject, "textTracks");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TextTrack AddTextTrack(global::Natrix.StdWeb.TextTrackKind kind)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = kind.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "addTextTrack", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextTrack>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TextTrack AddTextTrack(global::Natrix.StdWeb.TextTrackKind kind, string label)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = kind.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = label;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "addTextTrack", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextTrack>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TextTrack AddTextTrack(global::Natrix.StdWeb.TextTrackKind kind, string label, string language)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = kind.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = label;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        string ___marshalledValue_5;
        ___marshalledValue_5 = language;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "addTextTrack", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextTrack>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaStream CaptureStream()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "captureStream", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStream>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RemotePlayback Remote
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RemotePlayback>.Get(JSObject, "remote");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DisableRemotePlayback
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "disableRemotePlayback");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "disableRemotePlayback", value);
    }
}

#nullable disable