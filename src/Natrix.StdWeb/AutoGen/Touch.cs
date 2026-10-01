// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Touch: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Touch>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Touch(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Touch global::Natrix.JSCore.IJSObjectProxy<Touch>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Touch>(obj);

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
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "identifier");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventTarget Target
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.EventTarget>.Get(JSObject, "target");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScreenX
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "screenX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScreenY
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "screenY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ClientX
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "clientX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ClientY
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "clientY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PageX
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "pageX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PageY
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "pageY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float RadiusX
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "radiusX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float RadiusY
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "radiusY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float RotationAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "rotationAngle");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Force
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "force");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float AltitudeAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "altitudeAngle");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float AzimuthAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "azimuthAngle");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TouchType TouchType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TouchType>.Get(JSObject, "touchType");
    }
}

#nullable disable