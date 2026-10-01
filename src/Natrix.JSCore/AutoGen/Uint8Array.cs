// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public partial class Uint8Array: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Uint8Array>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Uint8Array(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Uint8Array global::Natrix.JSCore.IJSObjectProxy<Uint8Array>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Uint8Array>(obj);


}

#nullable disable