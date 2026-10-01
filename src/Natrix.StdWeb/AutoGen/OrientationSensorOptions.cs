// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OrientationSensorOptions: global::Natrix.StdWeb.SensorOptions, global::Natrix.JSCore.IJSObjectProxy<OrientationSensorOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OrientationSensorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OrientationSensorOptions global::Natrix.JSCore.IJSObjectProxy<OrientationSensorOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OrientationSensorOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.OrientationSensorLocalCoordinateSystem ReferenceFrame
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.OrientationSensorLocalCoordinateSystem, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OrientationSensorLocalCoordinateSystem>>(JSObject, "referenceFrame");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.OrientationSensorLocalCoordinateSystem, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OrientationSensorLocalCoordinateSystem>>(JSObject, "referenceFrame", value);
    }
}

#nullable disable