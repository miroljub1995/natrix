// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLUListElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLUListElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLUListElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLUListElement global::Natrix.JSCore.IJSObjectProxy<HTMLUListElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLUListElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLUListElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLUListElement");
        return new global::Natrix.StdWeb.HTMLUListElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Compact
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "compact");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "compact", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }
}

#nullable disable