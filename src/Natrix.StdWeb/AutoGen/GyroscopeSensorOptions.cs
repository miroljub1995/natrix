// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GyroscopeSensorOptions: global::Natrix.StdWeb.SensorOptions, global::Natrix.JSCore.IJSObjectProxy<GyroscopeSensorOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GyroscopeSensorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GyroscopeSensorOptions global::Natrix.JSCore.IJSObjectProxy<GyroscopeSensorOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GyroscopeSensorOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GyroscopeLocalCoordinateSystem ReferenceFrame
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GyroscopeLocalCoordinateSystem>.Get(JSObject, "referenceFrame");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GyroscopeLocalCoordinateSystem>.Set(JSObject, "referenceFrame", value);
    }
}

#nullable disable