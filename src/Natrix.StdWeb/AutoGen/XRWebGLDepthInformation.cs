// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRWebGLDepthInformation: global::Natrix.StdWeb.XRDepthInformation, global::Natrix.JSCore.IJSObjectProxy<XRWebGLDepthInformation>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRWebGLDepthInformation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRWebGLDepthInformation global::Natrix.JSCore.IJSObjectProxy<XRWebGLDepthInformation>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRWebGLDepthInformation>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebGLTexture Texture
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGLTexture>.Get(JSObject, "texture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRTextureType TextureType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRTextureType>.Get(JSObject, "textureType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? ImageIndex
    {
        get => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Get(JSObject, "imageIndex");
    }
}

#nullable disable