// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public partial class Float32Array: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Float32Array>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Float32Array(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Float32Array global::Natrix.JSCore.IJSObjectProxy<Float32Array>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Float32Array>(obj);


}

#nullable disable