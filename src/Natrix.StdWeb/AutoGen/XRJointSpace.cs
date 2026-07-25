// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRJointSpace: global::Natrix.StdWeb.XRSpace
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRJointSpace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRHandJoint JointName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRHandJoint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "jointName");
    }
}

#nullable disable