// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLTableCaptionElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLTableCaptionElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLTableCaptionElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLTableCaptionElement global::Natrix.JSCore.IJSObjectProxy<HTMLTableCaptionElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLTableCaptionElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLTableCaptionElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLTableCaptionElement");
        return new global::Natrix.StdWeb.HTMLTableCaptionElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Align
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "align");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "align", value);
    }
}

#nullable disable