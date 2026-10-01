// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLTimeElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLTimeElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLTimeElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLTimeElement global::Natrix.JSCore.IJSObjectProxy<HTMLTimeElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLTimeElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLTimeElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLTimeElement");
        return new global::Natrix.StdWeb.HTMLTimeElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DateTime
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "dateTime");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "dateTime", value);
    }
}

#nullable disable