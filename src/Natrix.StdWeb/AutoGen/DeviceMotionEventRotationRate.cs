// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DeviceMotionEventRotationRate: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DeviceMotionEventRotationRate>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceMotionEventRotationRate(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DeviceMotionEventRotationRate global::Natrix.JSCore.IJSObjectProxy<DeviceMotionEventRotationRate>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<DeviceMotionEventRotationRate>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Alpha
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "alpha");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Beta
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "beta");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Gamma
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "gamma");
    }
}

#nullable disable