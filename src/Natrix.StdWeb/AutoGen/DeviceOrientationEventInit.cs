// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DeviceOrientationEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<DeviceOrientationEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceOrientationEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DeviceOrientationEventInit global::Natrix.JSCore.IJSObjectProxy<DeviceOrientationEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceOrientationEventInit(): base()
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

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Absolute
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "absolute");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "absolute", value);
    }
}

#nullable disable