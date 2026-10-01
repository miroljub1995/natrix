// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLDListElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLDListElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLDListElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLDListElement global::Natrix.JSCore.IJSObjectProxy<HTMLDListElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLDListElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLDListElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLDListElement");
        return new global::Natrix.StdWeb.HTMLDListElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Compact
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "compact");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "compact", value);
    }
}

#nullable disable