// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WEBGL_compressed_texture_pvrtc: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WEBGL_compressed_texture_pvrtc>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WEBGL_compressed_texture_pvrtc(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WEBGL_compressed_texture_pvrtc global::Natrix.JSCore.IJSObjectProxy<WEBGL_compressed_texture_pvrtc>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WEBGL_compressed_texture_pvrtc>(obj);

    public const uint COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00;

    public const uint COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01;

    public const uint COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02;

    public const uint COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03;
}

#nullable disable