// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CaretPosition: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CaretPosition>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CaretPosition(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CaretPosition global::Natrix.JSCore.IJSObjectProxy<CaretPosition>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CaretPosition>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node OffsetNode
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "offsetNode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Offset
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "offset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRect? GetClientRect()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getClientRect", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DOMRect>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable