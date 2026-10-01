// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLDivElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLDivElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLDivElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLDivElement global::Natrix.JSCore.IJSObjectProxy<HTMLDivElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLDivElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLDivElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLDivElement");
        return new global::Natrix.StdWeb.HTMLDivElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Align
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "align");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "align", value);
    }
}

#nullable disable