// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EXT_color_buffer_half_float: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<EXT_color_buffer_half_float>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EXT_color_buffer_half_float(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EXT_color_buffer_half_float global::Natrix.JSCore.IJSObjectProxy<EXT_color_buffer_half_float>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<EXT_color_buffer_half_float>(obj);

    public const uint RGBA16F_EXT = 0x881A;

    public const uint RGB16F_EXT = 0x881B;

    public const uint FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT = 0x8211;

    public const uint UNSIGNED_NORMALIZED_EXT = 0x8C17;
}

#nullable disable