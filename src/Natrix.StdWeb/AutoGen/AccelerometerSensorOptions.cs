// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AccelerometerSensorOptions: global::Natrix.StdWeb.SensorOptions, global::Natrix.JSCore.IJSObjectProxy<AccelerometerSensorOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AccelerometerSensorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AccelerometerSensorOptions global::Natrix.JSCore.IJSObjectProxy<AccelerometerSensorOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AccelerometerSensorOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AccelerometerLocalCoordinateSystem ReferenceFrame
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AccelerometerLocalCoordinateSystem>.Get(JSObject, "referenceFrame");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AccelerometerLocalCoordinateSystem>.Set(JSObject, "referenceFrame", value);
    }
}

#nullable disable