// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EXT_texture_compression_bptc: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<EXT_texture_compression_bptc>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EXT_texture_compression_bptc(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EXT_texture_compression_bptc global::Natrix.JSCore.IJSObjectProxy<EXT_texture_compression_bptc>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<EXT_texture_compression_bptc>(obj);

    public const uint COMPRESSED_RGBA_BPTC_UNORM_EXT = 0x8E8C;

    public const uint COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT = 0x8E8D;

    public const uint COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT = 0x8E8E;

    public const uint COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT = 0x8E8F;
}

#nullable disable