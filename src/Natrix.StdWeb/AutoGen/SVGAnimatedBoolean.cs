// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGAnimatedBoolean: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedBoolean>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGAnimatedBoolean(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGAnimatedBoolean global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedBoolean>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGAnimatedBoolean>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BaseVal
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "baseVal");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "baseVal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AnimVal
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "animVal");
    }
}

#nullable disable