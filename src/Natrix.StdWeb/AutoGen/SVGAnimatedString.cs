// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGAnimatedString: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedString>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGAnimatedString(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGAnimatedString global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedString>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGAnimatedString>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.TrustedScriptURL, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScriptURL>> BaseVal
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.TrustedScriptURL, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScriptURL>>>.Get(JSObject, "baseVal");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.TrustedScriptURL, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScriptURL>>>.Set(JSObject, "baseVal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AnimVal
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "animVal");
    }
}

#nullable disable