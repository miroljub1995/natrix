// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioSession: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<AudioSession>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioSession(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioSession global::Natrix.JSCore.IJSObjectProxy<AudioSession>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AudioSession>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioSessionType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AudioSessionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioSessionType>>(JSObject, "type");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AudioSessionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioSessionType>>(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioSessionState State
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AudioSessionState, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioSessionState>>(JSObject, "state");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onstatechange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onstatechange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onstatechange", value);
    }
}

#nullable disable