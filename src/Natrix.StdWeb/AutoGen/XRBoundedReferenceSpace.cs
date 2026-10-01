// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRBoundedReferenceSpace: global::Natrix.StdWeb.XRReferenceSpace, global::Natrix.JSCore.IJSObjectProxy<XRBoundedReferenceSpace>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRBoundedReferenceSpace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRBoundedReferenceSpace global::Natrix.JSCore.IJSObjectProxy<XRBoundedReferenceSpace>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRBoundedReferenceSpace>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMPointReadOnly, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>> BoundsGeometry
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMPointReadOnly, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>>>.Get(JSObject, "boundsGeometry");
    }
}

#nullable disable