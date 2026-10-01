// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WEBGL_debug_renderer_info: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WEBGL_debug_renderer_info>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WEBGL_debug_renderer_info(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WEBGL_debug_renderer_info global::Natrix.JSCore.IJSObjectProxy<WEBGL_debug_renderer_info>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WEBGL_debug_renderer_info>(obj);

    public const uint UNMASKED_VENDOR_WEBGL = 0x9245;

    public const uint UNMASKED_RENDERER_WEBGL = 0x9246;
}

#nullable disable