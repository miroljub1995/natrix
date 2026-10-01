// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VTTRegion: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VTTRegion>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VTTRegion(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VTTRegion global::Natrix.JSCore.IJSObjectProxy<VTTRegion>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<VTTRegion>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.VTTRegion New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "VTTRegion");
        return new global::Natrix.StdWeb.VTTRegion(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Width
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Lines
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "lines");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "lines", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RegionAnchorX
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "regionAnchorX");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "regionAnchorX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RegionAnchorY
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "regionAnchorY");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "regionAnchorY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ViewportAnchorX
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "viewportAnchorX");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "viewportAnchorX", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ViewportAnchorY
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "viewportAnchorY");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "viewportAnchorY", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScrollSetting Scroll
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScrollSetting>.Get(JSObject, "scroll");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScrollSetting>.Set(JSObject, "scroll", value);
    }
}

#nullable disable