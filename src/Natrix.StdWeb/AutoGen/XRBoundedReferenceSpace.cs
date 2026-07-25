// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRBoundedReferenceSpace: global::Natrix.StdWeb.XRReferenceSpace
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRBoundedReferenceSpace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMPointReadOnly, global::Natrix.StdWeb.PropertyAccessor> BoundsGeometry
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMPointReadOnly, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "boundsGeometry");
    }
}

#nullable disable