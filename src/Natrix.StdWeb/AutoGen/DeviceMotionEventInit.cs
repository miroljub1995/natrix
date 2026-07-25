// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DeviceMotionEventInit: global::Natrix.StdWeb.EventInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceMotionEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceMotionEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DeviceMotionEventAccelerationInit Acceleration
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DeviceMotionEventAccelerationInit, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "acceleration");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DeviceMotionEventAccelerationInit, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "acceleration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DeviceMotionEventAccelerationInit AccelerationIncludingGravity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DeviceMotionEventAccelerationInit, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "accelerationIncludingGravity");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DeviceMotionEventAccelerationInit, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "accelerationIncludingGravity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DeviceMotionEventRotationRateInit RotationRate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DeviceMotionEventRotationRateInit, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rotationRate");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DeviceMotionEventRotationRateInit, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rotationRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Interval
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "interval");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "interval", value);
    }
}

#nullable disable