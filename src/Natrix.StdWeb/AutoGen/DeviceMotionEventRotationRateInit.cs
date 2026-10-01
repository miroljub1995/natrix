// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DeviceMotionEventRotationRateInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DeviceMotionEventRotationRateInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceMotionEventRotationRateInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DeviceMotionEventRotationRateInit global::Natrix.JSCore.IJSObjectProxy<DeviceMotionEventRotationRateInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceMotionEventRotationRateInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Alpha
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Set(JSObject, "alpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Beta
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "beta");
        set => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Set(JSObject, "beta", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Gamma
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "gamma");
        set => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Set(JSObject, "gamma", value);
    }
}

#nullable disable