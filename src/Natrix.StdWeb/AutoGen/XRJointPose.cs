// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRJointPose: global::Natrix.StdWeb.XRPose, global::Natrix.JSCore.IJSObjectProxy<XRJointPose>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRJointPose(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRJointPose global::Natrix.JSCore.IJSObjectProxy<XRJointPose>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRJointPose>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Radius
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "radius");
    }
}

#nullable disable