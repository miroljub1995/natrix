// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRLightProbe: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<XRLightProbe>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRLightProbe(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRLightProbe global::Natrix.JSCore.IJSObjectProxy<XRLightProbe>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRLightProbe>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSpace ProbeSpace
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRSpace, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>>(JSObject, "probeSpace");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onreflectionchange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onreflectionchange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onreflectionchange", value);
    }
}

#nullable disable