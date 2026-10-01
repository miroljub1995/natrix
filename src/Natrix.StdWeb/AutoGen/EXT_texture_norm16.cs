// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EXT_texture_norm16: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<EXT_texture_norm16>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EXT_texture_norm16(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EXT_texture_norm16 global::Natrix.JSCore.IJSObjectProxy<EXT_texture_norm16>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<EXT_texture_norm16>(obj);

    public const uint R16_EXT = 0x822A;

    public const uint RG16_EXT = 0x822C;

    public const uint RGB16_EXT = 0x8054;

    public const uint RGBA16_EXT = 0x805B;

    public const uint R16_SNORM_EXT = 0x8F98;

    public const uint RG16_SNORM_EXT = 0x8F99;

    public const uint RGB16_SNORM_EXT = 0x8F9A;

    public const uint RGBA16_SNORM_EXT = 0x8F9B;
}

#nullable disable