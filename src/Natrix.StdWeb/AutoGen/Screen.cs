// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Screen: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Screen>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Screen(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Screen global::Natrix.JSCore.IJSObjectProxy<Screen>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Screen>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int AvailWidth
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "availWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int AvailHeight
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "availHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Width
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "width");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Height
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "height");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ColorDepth
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "colorDepth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint PixelDepth
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "pixelDepth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScreenOrientation Orientation
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ScreenOrientation>.Get(JSObject, "orientation");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsExtended
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isExtended");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onchange", value);
    }
}

#nullable disable