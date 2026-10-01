// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLSelectedContentElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLSelectedContentElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLSelectedContentElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLSelectedContentElement global::Natrix.JSCore.IJSObjectProxy<HTMLSelectedContentElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLSelectedContentElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLSelectedContentElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLSelectedContentElement");
        return new global::Natrix.StdWeb.HTMLSelectedContentElement(___res_2);
    }
}

#nullable disable