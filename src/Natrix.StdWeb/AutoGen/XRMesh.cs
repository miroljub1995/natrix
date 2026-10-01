// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRMesh: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRMesh>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRMesh(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRMesh global::Natrix.JSCore.IJSObjectProxy<XRMesh>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRMesh>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSpace MeshSpace
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>.Get(JSObject, "meshSpace");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array Vertices
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>.Get(JSObject, "vertices");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Uint32Array Indices
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>.Get(JSObject, "indices");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LastChangedTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "lastChangedTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SemanticLabel
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "semanticLabel");
    }
}

#nullable disable