// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TouchInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TouchInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TouchInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TouchInit global::Natrix.JSCore.IJSObjectProxy<TouchInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TouchInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required int Identifier
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "identifier");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "identifier", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.EventTarget Target
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.EventTarget>.Get(JSObject, "target");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.EventTarget>.Set(JSObject, "target", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ClientX
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "clientX");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "clientX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ClientY
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "clientY");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "clientY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScreenX
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "screenX");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "screenX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScreenY
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "screenY");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "screenY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PageX
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "pageX");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "pageX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PageY
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "pageY");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "pageY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float RadiusX
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "radiusX");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "radiusX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float RadiusY
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "radiusY");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "radiusY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float RotationAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "rotationAngle");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "rotationAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Force
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "force");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "force", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AltitudeAngle
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "altitudeAngle");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "altitudeAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AzimuthAngle
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "azimuthAngle");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "azimuthAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TouchType TouchType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TouchType>.Get(JSObject, "touchType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TouchType>.Set(JSObject, "touchType", value);
    }
}

#nullable disable