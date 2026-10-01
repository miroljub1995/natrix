// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLModElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLModElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLModElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLModElement global::Natrix.JSCore.IJSObjectProxy<HTMLModElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLModElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLModElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLModElement");
        return new global::Natrix.StdWeb.HTMLModElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Cite
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "cite");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "cite", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DateTime
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "dateTime");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "dateTime", value);
    }
}

#nullable disable