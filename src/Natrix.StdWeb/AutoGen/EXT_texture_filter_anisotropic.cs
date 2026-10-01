// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EXT_texture_filter_anisotropic: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<EXT_texture_filter_anisotropic>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EXT_texture_filter_anisotropic(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EXT_texture_filter_anisotropic global::Natrix.JSCore.IJSObjectProxy<EXT_texture_filter_anisotropic>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<EXT_texture_filter_anisotropic>(obj);

    public const uint TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;

    public const uint MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
}

#nullable disable