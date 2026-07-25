// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Touch: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Touch(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.Touch New(global::Natrix.StdWeb.TouchInit touchInitDict)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = touchInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Touch", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.Touch(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Identifier
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "identifier");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventTarget Target
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventTarget, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "target");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScreenX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "screenX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScreenY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "screenY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ClientX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clientX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ClientY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clientY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PageX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pageX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PageY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pageY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float RadiusX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "radiusX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float RadiusY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "radiusY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float RotationAngle
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rotationAngle");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Force
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "force");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float AltitudeAngle
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "altitudeAngle");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float AzimuthAngle
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "azimuthAngle");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TouchType TouchType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.TouchType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "touchType");
    }
}

#nullable disable