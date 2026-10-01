// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRBodySpace: global::Natrix.StdWeb.XRSpace, global::Natrix.JSCore.IJSObjectProxy<XRBodySpace>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRBodySpace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRBodySpace global::Natrix.JSCore.IJSObjectProxy<XRBodySpace>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRBodySpace>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRBodyJoint JointName
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRBodyJoint>.Get(JSObject, "jointName");
    }
}

#nullable disable