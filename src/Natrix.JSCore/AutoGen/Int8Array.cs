// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public partial class Int8Array: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Int8Array>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Int8Array(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Int8Array global::Natrix.JSCore.IJSObjectProxy<Int8Array>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Int8Array>(obj);


}

#nullable disable