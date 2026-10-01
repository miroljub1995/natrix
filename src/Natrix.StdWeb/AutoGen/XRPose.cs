// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRPose: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRPose>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRPose(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRPose global::Natrix.JSCore.IJSObjectProxy<XRPose>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRPose>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRigidTransform Transform
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>.Get(JSObject, "transform");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly? LinearVelocity
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Get(JSObject, "linearVelocity");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly? AngularVelocity
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Get(JSObject, "angularVelocity");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool EmulatedPosition
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "emulatedPosition");
    }
}

#nullable disable