// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EXT_sRGB: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<EXT_sRGB>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EXT_sRGB(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EXT_sRGB global::Natrix.JSCore.IJSObjectProxy<EXT_sRGB>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<EXT_sRGB>(obj);

    public const uint SRGB_EXT = 0x8C40;

    public const uint SRGB_ALPHA_EXT = 0x8C42;

    public const uint SRGB8_ALPHA8_EXT = 0x8C43;

    public const uint FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210;
}

#nullable disable