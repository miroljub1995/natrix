// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TextTrackCue: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<TextTrackCue>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextTrackCue(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TextTrackCue global::Natrix.JSCore.IJSObjectProxy<TextTrackCue>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TextTrackCue>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TextTrack? Track
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.TextTrack>.Get(JSObject, "track");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double StartTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "startTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "startTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EndTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "endTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "endTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PauseOnExit
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "pauseOnExit");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "pauseOnExit", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onenter
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onenter");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onenter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onexit
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onexit");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onexit", value);
    }
}

#nullable disable