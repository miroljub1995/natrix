// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BarProp: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BarProp>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BarProp(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BarProp global::Natrix.JSCore.IJSObjectProxy<BarProp>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BarProp>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Visible
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "visible");
    }
}

#nullable disable