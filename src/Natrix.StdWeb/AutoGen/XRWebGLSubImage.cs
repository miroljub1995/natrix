// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRWebGLSubImage: global::Natrix.StdWeb.XRSubImage, global::Natrix.JSCore.IJSObjectProxy<XRWebGLSubImage>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRWebGLSubImage(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRWebGLSubImage global::Natrix.JSCore.IJSObjectProxy<XRWebGLSubImage>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRWebGLSubImage>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebGLTexture ColorTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebGLTexture, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGLTexture>>(JSObject, "colorTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebGLTexture? DepthStencilTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebGLTexture?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WebGLTexture>>(JSObject, "depthStencilTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebGLTexture? MotionVectorTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebGLTexture?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WebGLTexture>>(JSObject, "motionVectorTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? ImageIndex
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.JSCore.Generics.NullableUInt32Accessor>(JSObject, "imageIndex");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ColorTextureWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "colorTextureWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ColorTextureHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "colorTextureHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? DepthStencilTextureWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.JSCore.Generics.NullableUInt32Accessor>(JSObject, "depthStencilTextureWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? DepthStencilTextureHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.JSCore.Generics.NullableUInt32Accessor>(JSObject, "depthStencilTextureHeight");
    }
}

#nullable disable