// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DeviceMotionEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<DeviceMotionEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceMotionEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DeviceMotionEventInit global::Natrix.JSCore.IJSObjectProxy<DeviceMotionEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceMotionEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DeviceMotionEventAccelerationInit Acceleration
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DeviceMotionEventAccelerationInit>.Get(JSObject, "acceleration");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DeviceMotionEventAccelerationInit>.Set(JSObject, "acceleration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DeviceMotionEventAccelerationInit AccelerationIncludingGravity
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DeviceMotionEventAccelerationInit>.Get(JSObject, "accelerationIncludingGravity");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DeviceMotionEventAccelerationInit>.Set(JSObject, "accelerationIncludingGravity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DeviceMotionEventRotationRateInit RotationRate
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DeviceMotionEventRotationRateInit>.Get(JSObject, "rotationRate");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DeviceMotionEventRotationRateInit>.Set(JSObject, "rotationRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Interval
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "interval");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "interval", value);
    }
}

#nullable disable