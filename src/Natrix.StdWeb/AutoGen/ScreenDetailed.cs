// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ScreenDetailed: global::Natrix.StdWeb.Screen
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ScreenDetailed(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int AvailLeft
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "availLeft");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int AvailTop
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "availTop");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Left
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "left");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Top
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "top");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsPrimary
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isPrimary");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsInternal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isInternal");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DevicePixelRatio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "devicePixelRatio");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "label");
    }
}

#nullable disable