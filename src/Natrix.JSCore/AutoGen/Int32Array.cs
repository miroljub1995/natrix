// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public partial class Int32Array: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Int32Array>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Int32Array(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Int32Array global::Natrix.JSCore.IJSObjectProxy<Int32Array>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Int32Array>(obj);


}

#nullable disable