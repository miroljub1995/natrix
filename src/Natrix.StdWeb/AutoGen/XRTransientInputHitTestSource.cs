// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRTransientInputHitTestSource: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRTransientInputHitTestSource(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Cancel()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "cancel", JSObject);
    }
}

#nullable disable