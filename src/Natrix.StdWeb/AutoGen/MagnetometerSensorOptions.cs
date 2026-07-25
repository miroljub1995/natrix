// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MagnetometerSensorOptions: global::Natrix.StdWeb.SensorOptions
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MagnetometerSensorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MagnetometerSensorOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MagnetometerLocalCoordinateSystem ReferenceFrame
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MagnetometerLocalCoordinateSystem, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "referenceFrame");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MagnetometerLocalCoordinateSystem, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "referenceFrame", value);
    }
}

#nullable disable