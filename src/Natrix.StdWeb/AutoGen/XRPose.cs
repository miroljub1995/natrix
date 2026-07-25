// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRPose: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRPose(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRigidTransform Transform
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRRigidTransform, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transform");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly? LinearVelocity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMPointReadOnly?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "linearVelocity");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly? AngularVelocity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMPointReadOnly?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "angularVelocity");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool EmulatedPosition
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "emulatedPosition");
    }
}

#nullable disable