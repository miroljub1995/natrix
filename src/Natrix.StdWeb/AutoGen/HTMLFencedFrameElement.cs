// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLFencedFrameElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLFencedFrameElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLFencedFrameElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLFencedFrameElement global::Natrix.JSCore.IJSObjectProxy<HTMLFencedFrameElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLFencedFrameElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLFencedFrameElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLFencedFrameElement");
        return new global::Natrix.StdWeb.HTMLFencedFrameElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FencedFrameConfig? Config
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.FencedFrameConfig>.Get(JSObject, "config");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.FencedFrameConfig>.Set(JSObject, "config", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Width
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Height
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList Sandbox
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "sandbox");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Allow
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "allow");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "allow", value);
    }
}

#nullable disable