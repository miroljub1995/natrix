// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public partial class SharedArrayBuffer: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SharedArrayBuffer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SharedArrayBuffer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SharedArrayBuffer global::Natrix.JSCore.IJSObjectProxy<SharedArrayBuffer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SharedArrayBuffer>(obj);


}

#nullable disable