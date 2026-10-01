// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageDataSettings: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImageDataSettings>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageDataSettings(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImageDataSettings global::Natrix.JSCore.IJSObjectProxy<ImageDataSettings>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageDataSettings(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PredefinedColorSpace ColorSpace
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PredefinedColorSpace>.Get(JSObject, "colorSpace");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PredefinedColorSpace>.Set(JSObject, "colorSpace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ImageDataPixelFormat PixelFormat
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ImageDataPixelFormat>.Get(JSObject, "pixelFormat");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ImageDataPixelFormat>.Set(JSObject, "pixelFormat", value);
    }
}

#nullable disable