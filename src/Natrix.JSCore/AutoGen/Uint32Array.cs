// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public partial class Uint32Array: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Uint32Array>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Uint32Array(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Uint32Array global::Natrix.JSCore.IJSObjectProxy<Uint32Array>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Uint32Array>(obj);


}

#nullable disable