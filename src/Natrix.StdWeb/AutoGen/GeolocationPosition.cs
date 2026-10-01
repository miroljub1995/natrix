// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GeolocationPosition: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GeolocationPosition>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GeolocationPosition(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GeolocationPosition global::Natrix.JSCore.IJSObjectProxy<GeolocationPosition>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GeolocationPosition>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GeolocationCoordinates Coords
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GeolocationCoordinates>.Get(JSObject, "coords");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Timestamp
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "timestamp");
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