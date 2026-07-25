// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Screen: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Screen(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int AvailWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "availWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int AvailHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "availHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Height
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "height");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ColorDepth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "colorDepth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint PixelDepth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pixelDepth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsExtended
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isExtended");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "onchange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "onchange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScreenOrientation Orientation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ScreenOrientation, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "orientation");
    }
}

#nullable disable