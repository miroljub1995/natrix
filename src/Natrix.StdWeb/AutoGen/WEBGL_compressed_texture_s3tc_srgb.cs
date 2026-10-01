// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WEBGL_compressed_texture_s3tc_srgb: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WEBGL_compressed_texture_s3tc_srgb>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WEBGL_compressed_texture_s3tc_srgb(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WEBGL_compressed_texture_s3tc_srgb global::Natrix.JSCore.IJSObjectProxy<WEBGL_compressed_texture_s3tc_srgb>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WEBGL_compressed_texture_s3tc_srgb>(obj);

    public const uint COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;

    public const uint COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;

    public const uint COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;

    public const uint COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;
}

#nullable disable