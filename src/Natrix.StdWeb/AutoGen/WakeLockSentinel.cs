// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WakeLockSentinel: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<WakeLockSentinel>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WakeLockSentinel(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WakeLockSentinel global::Natrix.JSCore.IJSObjectProxy<WakeLockSentinel>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WakeLockSentinel>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Released
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "released");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WakeLockType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WakeLockType>.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Release()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "release", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onrelease
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onrelease");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onrelease", value);
    }
}

#nullable disable