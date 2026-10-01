// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGAnimatedEnumeration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedEnumeration>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGAnimatedEnumeration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGAnimatedEnumeration global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedEnumeration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGAnimatedEnumeration>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort BaseVal
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "baseVal");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "baseVal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort AnimVal
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "animVal");
    }
}

#nullable disable