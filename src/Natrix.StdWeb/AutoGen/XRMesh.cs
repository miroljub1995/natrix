// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRMesh: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRMesh(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSpace MeshSpace
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRSpace, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "meshSpace");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array Vertices
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Float32Array, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vertices");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Uint32Array Indices
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Uint32Array, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "indices");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LastChangedTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lastChangedTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SemanticLabel
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "semanticLabel");
    }
}

#nullable disable