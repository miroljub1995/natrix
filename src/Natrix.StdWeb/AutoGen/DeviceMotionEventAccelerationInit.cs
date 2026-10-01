// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DeviceMotionEventAccelerationInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DeviceMotionEventAccelerationInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceMotionEventAccelerationInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DeviceMotionEventAccelerationInit global::Natrix.JSCore.IJSObjectProxy<DeviceMotionEventAccelerationInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceMotionEventAccelerationInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? X
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "x");
        set => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Set(JSObject, "x", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Y
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "y");
        set => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Set(JSObject, "y", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Z
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "z");
        set => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Set(JSObject, "z", value);
    }
}

#nullable disable