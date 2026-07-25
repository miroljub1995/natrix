// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRWebGLDepthInformation: global::Natrix.StdWeb.XRDepthInformation
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRWebGLDepthInformation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebGLTexture Texture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebGLTexture, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "texture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRTextureType TextureType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRTextureType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "textureType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? ImageIndex
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "imageIndex");
    }
}

#nullable disable