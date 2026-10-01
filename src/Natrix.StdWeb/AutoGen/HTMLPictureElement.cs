// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLPictureElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLPictureElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLPictureElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLPictureElement global::Natrix.JSCore.IJSObjectProxy<HTMLPictureElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLPictureElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLPictureElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLPictureElement");
        return new global::Natrix.StdWeb.HTMLPictureElement(___res_2);
    }
}

#nullable disable