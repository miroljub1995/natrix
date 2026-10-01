// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PointerEventInit: global::Natrix.StdWeb.MouseEventInit, global::Natrix.JSCore.IJSObjectProxy<PointerEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PointerEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PointerEventInit global::Natrix.JSCore.IJSObjectProxy<PointerEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PointerEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int PointerId
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "pointerId");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "pointerId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Width
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Height
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Pressure
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "pressure");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "pressure", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float TangentialPressure
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "tangentialPressure");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "tangentialPressure", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int TiltX
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "tiltX");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "tiltX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int TiltY
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "tiltY");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "tiltY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Twist
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "twist");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "twist", value);
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
    public string PointerType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "pointerType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "pointerType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsPrimary
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isPrimary");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isPrimary", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int PersistentDeviceId
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "persistentDeviceId");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "persistentDeviceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PointerEvent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PointerEvent>> CoalescedEvents
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PointerEvent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PointerEvent>>>.Get(JSObject, "coalescedEvents");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PointerEvent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PointerEvent>>>.Set(JSObject, "coalescedEvents", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PointerEvent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PointerEvent>> PredictedEvents
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PointerEvent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PointerEvent>>>.Get(JSObject, "predictedEvents");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PointerEvent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PointerEvent>>>.Set(JSObject, "predictedEvents", value);
    }
}

#nullable disable