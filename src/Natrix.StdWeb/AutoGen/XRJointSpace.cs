// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRJointSpace: global::Natrix.StdWeb.XRSpace, global::Natrix.JSCore.IJSObjectProxy<XRJointSpace>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRJointSpace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRJointSpace global::Natrix.JSCore.IJSObjectProxy<XRJointSpace>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRJointSpace>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRHandJoint JointName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRHandJoint, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRHandJoint>>(JSObject, "jointName");
    }
}

#nullable disable