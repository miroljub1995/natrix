// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public partial class ArrayBuffer: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ArrayBuffer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ArrayBuffer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ArrayBuffer global::Natrix.JSCore.IJSObjectProxy<ArrayBuffer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ArrayBuffer>(obj);


}

#nullable disable