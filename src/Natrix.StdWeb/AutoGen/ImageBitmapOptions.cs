// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageBitmapOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImageBitmapOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageBitmapOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImageBitmapOptions global::Natrix.JSCore.IJSObjectProxy<ImageBitmapOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageBitmapOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ImageOrientation ImageOrientation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ImageOrientation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ImageOrientation>>(JSObject, "imageOrientation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ImageOrientation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ImageOrientation>>(JSObject, "imageOrientation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PremultiplyAlpha PremultiplyAlpha
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PremultiplyAlpha, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PremultiplyAlpha>>(JSObject, "premultiplyAlpha");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PremultiplyAlpha, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PremultiplyAlpha>>(JSObject, "premultiplyAlpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ColorSpaceConversion ColorSpaceConversion
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ColorSpaceConversion, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ColorSpaceConversion>>(JSObject, "colorSpaceConversion");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ColorSpaceConversion, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ColorSpaceConversion>>(JSObject, "colorSpaceConversion", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ResizeWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "resizeWidth");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "resizeWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ResizeHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "resizeHeight");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "resizeHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ResizeQuality ResizeQuality
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ResizeQuality, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ResizeQuality>>(JSObject, "resizeQuality");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ResizeQuality, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ResizeQuality>>(JSObject, "resizeQuality", value);
    }
}

#nullable disable