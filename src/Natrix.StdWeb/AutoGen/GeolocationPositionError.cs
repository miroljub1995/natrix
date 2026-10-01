// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GeolocationPositionError: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GeolocationPositionError>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GeolocationPositionError(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GeolocationPositionError global::Natrix.JSCore.IJSObjectProxy<GeolocationPositionError>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GeolocationPositionError>(obj);

    public const ushort PERMISSION_DENIED = 1;

    public const ushort POSITION_UNAVAILABLE = 2;

    public const ushort TIMEOUT = 3;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Code
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>(JSObject, "code");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Message
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "message");
    }
}

#nullable disable