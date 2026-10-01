// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGAnimatedNumber: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedNumber>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGAnimatedNumber(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGAnimatedNumber global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedNumber>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGAnimatedNumber>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float BaseVal
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "baseVal");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "baseVal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float AnimVal
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "animVal");
    }
}

#nullable disable