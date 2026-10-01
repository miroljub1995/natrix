// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public partial class Promise: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Promise>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Promise(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Promise global::Natrix.JSCore.IJSObjectProxy<Promise>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Promise>(obj);


}

#nullable disable