// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGScriptElement: global::Natrix.StdWeb.SVGElement, global::Natrix.JSCore.IJSObjectProxy<SVGScriptElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGScriptElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGScriptElement global::Natrix.JSCore.IJSObjectProxy<SVGScriptElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGScriptElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? CrossOrigin
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "crossOrigin");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "crossOrigin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString Href
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedString>.Get(JSObject, "href");
    }
}

#nullable disable