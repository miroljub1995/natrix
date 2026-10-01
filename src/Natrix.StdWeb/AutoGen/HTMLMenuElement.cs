// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLMenuElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLMenuElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLMenuElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLMenuElement global::Natrix.JSCore.IJSObjectProxy<HTMLMenuElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLMenuElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLMenuElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLMenuElement");
        return new global::Natrix.StdWeb.HTMLMenuElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Compact
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "compact");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "compact", value);
    }
}

#nullable disable