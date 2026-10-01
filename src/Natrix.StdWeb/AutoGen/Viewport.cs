// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Viewport: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Viewport>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Viewport(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Viewport global::Natrix.JSCore.IJSObjectProxy<Viewport>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Viewport>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRect>>? Segments
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRect>>>.Get(JSObject, "segments");
    }
}

#nullable disable