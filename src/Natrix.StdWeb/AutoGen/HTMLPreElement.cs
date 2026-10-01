// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLPreElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLPreElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLPreElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLPreElement global::Natrix.JSCore.IJSObjectProxy<HTMLPreElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLPreElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLPreElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLPreElement");
        return new global::Natrix.StdWeb.HTMLPreElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Width
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "width", value);
    }
}

#nullable disable