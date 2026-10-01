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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "availLeft");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int AvailTop
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "availTop");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Left
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "left");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Top
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "top");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsPrimary
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "isPrimary");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsInternal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "isInternal");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DevicePixelRatio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "devicePixelRatio");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "label");
    }
}

#nullable disable