// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public partial class Float16Array: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Float16Array>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Float16Array(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Float16Array global::Natrix.JSCore.IJSObjectProxy<Float16Array>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Float16Array>(obj);


}

#nullable disable