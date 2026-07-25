// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRWebGLSubImage: global::Natrix.StdWeb.XRSubImage
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRWebGLSubImage(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebGLTexture ColorTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebGLTexture, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "colorTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebGLTexture? DepthStencilTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebGLTexture?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "depthStencilTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebGLTexture? MotionVectorTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebGLTexture?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "motionVectorTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? ImageIndex
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "imageIndex");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ColorTextureWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "colorTextureWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ColorTextureHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "colorTextureHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? DepthStencilTextureWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "depthStencilTextureWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? DepthStencilTextureHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "depthStencilTextureHeight");
    }
}

#nullable disable