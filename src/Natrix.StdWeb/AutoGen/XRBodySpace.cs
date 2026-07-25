// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRBodySpace: global::Natrix.StdWeb.XRSpace
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRBodySpace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRBodyJoint JointName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRBodyJoint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "jointName");
    }
}

#nullable disable