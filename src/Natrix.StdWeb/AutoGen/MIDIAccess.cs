// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MIDIAccess: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<MIDIAccess>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MIDIAccess(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MIDIAccess global::Natrix.JSCore.IJSObjectProxy<MIDIAccess>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MIDIAccess>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MIDIInputMap Inputs
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MIDIInputMap>.Get(JSObject, "inputs");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MIDIOutputMap Outputs
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MIDIOutputMap>.Get(JSObject, "outputs");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onstatechange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onstatechange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onstatechange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SysexEnabled
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "sysexEnabled");
    }
}

#nullable disable