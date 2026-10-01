// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EXT_blend_minmax: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<EXT_blend_minmax>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EXT_blend_minmax(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EXT_blend_minmax global::Natrix.JSCore.IJSObjectProxy<EXT_blend_minmax>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<EXT_blend_minmax>(obj);

    public const uint MIN_EXT = 0x8007;

    public const uint MAX_EXT = 0x8008;
}

#nullable disable