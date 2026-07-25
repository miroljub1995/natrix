// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRJointPose: global::Natrix.StdWeb.XRPose
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRJointPose(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Radius
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "radius");
    }
}

#nullable disable