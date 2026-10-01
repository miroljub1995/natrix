// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceNavigation: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PerformanceNavigation>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceNavigation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceNavigation global::Natrix.JSCore.IJSObjectProxy<PerformanceNavigation>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformanceNavigation>(obj);

    public const ushort TYPE_NAVIGATE = 0;

    public const ushort TYPE_RELOAD = 1;

    public const ushort TYPE_BACK_FORWARD = 2;

    public const ushort TYPE_RESERVED = 255;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Type
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort RedirectCount
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "redirectCount");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable