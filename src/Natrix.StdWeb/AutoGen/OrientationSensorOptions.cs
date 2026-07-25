// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OrientationSensorOptions: global::Natrix.StdWeb.SensorOptions
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OrientationSensorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OrientationSensorOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.OrientationSensorLocalCoordinateSystem ReferenceFrame
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.OrientationSensorLocalCoordinateSystem, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "referenceFrame");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.OrientationSensorLocalCoordinateSystem, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "referenceFrame", value);
    }
}

#nullable disable