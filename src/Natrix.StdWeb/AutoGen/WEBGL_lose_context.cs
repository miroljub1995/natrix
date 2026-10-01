// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WEBGL_lose_context: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WEBGL_lose_context>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WEBGL_lose_context(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WEBGL_lose_context global::Natrix.JSCore.IJSObjectProxy<WEBGL_lose_context>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WEBGL_lose_context>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void LoseContext()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "loseContext", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RestoreContext()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "restoreContext", JSObject);
    }
}

#nullable disable