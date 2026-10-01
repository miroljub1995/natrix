// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DeviceMotionEventAcceleration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DeviceMotionEventAcceleration>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceMotionEventAcceleration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DeviceMotionEventAcceleration global::Natrix.JSCore.IJSObjectProxy<DeviceMotionEventAcceleration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<DeviceMotionEventAcceleration>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? X
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "x");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Y
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "y");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Z
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "z");
    }
}

#nullable disable