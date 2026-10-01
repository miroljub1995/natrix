// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public partial class Float64Array: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Float64Array>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Float64Array(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Float64Array global::Natrix.JSCore.IJSObjectProxy<Float64Array>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Float64Array>(obj);


}

#nullable disable