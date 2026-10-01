// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OES_standard_derivatives: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<OES_standard_derivatives>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OES_standard_derivatives(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OES_standard_derivatives global::Natrix.JSCore.IJSObjectProxy<OES_standard_derivatives>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<OES_standard_derivatives>(obj);

    public const uint FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B;
}

#nullable disable