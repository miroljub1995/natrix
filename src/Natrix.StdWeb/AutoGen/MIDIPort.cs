// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MIDIPort: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<MIDIPort>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MIDIPort(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MIDIPort global::Natrix.JSCore.IJSObjectProxy<MIDIPort>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MIDIPort>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Manufacturer
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "manufacturer");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Name
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MIDIPortType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MIDIPortType>.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Version
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "version");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MIDIPortDeviceState State
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MIDIPortDeviceState>.Get(JSObject, "state");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MIDIPortConnectionState Connection
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MIDIPortConnectionState>.Get(JSObject, "connection");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onstatechange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onstatechange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onstatechange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MIDIPort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MIDIPort>> Open()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "open", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MIDIPort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MIDIPort>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MIDIPort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MIDIPort>> Close()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "close", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MIDIPort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MIDIPort>>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable