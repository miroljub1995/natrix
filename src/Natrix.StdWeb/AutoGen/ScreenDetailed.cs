// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ScreenDetailed: global::Natrix.StdWeb.Screen, global::Natrix.JSCore.IJSObjectProxy<ScreenDetailed>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ScreenDetailed(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ScreenDetailed global::Natrix.JSCore.IJSObjectProxy<ScreenDetailed>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ScreenDetailed>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int AvailLeft
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "availLeft");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int AvailTop
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "availTop");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Left
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "left");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Top
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "top");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsPrimary
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isPrimary");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsInternal
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isInternal");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DevicePixelRatio
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "devicePixelRatio");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
    }
}

#nullable disable