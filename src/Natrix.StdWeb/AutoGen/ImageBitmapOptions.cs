// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageBitmapOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageBitmapOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageBitmapOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ImageOrientation ImageOrientation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ImageOrientation, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "imageOrientation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ImageOrientation, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "imageOrientation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PremultiplyAlpha PremultiplyAlpha
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PremultiplyAlpha, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "premultiplyAlpha");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PremultiplyAlpha, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "premultiplyAlpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ColorSpaceConversion ColorSpaceConversion
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ColorSpaceConversion, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "colorSpaceConversion");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ColorSpaceConversion, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "colorSpaceConversion", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ResizeWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "resizeWidth");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "resizeWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ResizeHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "resizeHeight");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "resizeHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ResizeQuality ResizeQuality
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ResizeQuality, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "resizeQuality");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ResizeQuality, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "resizeQuality", value);
    }
}

#nullable disable