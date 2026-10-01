// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLDetailsElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLDetailsElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLDetailsElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLDetailsElement global::Natrix.JSCore.IJSObjectProxy<HTMLDetailsElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLDetailsElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLDetailsElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLDetailsElement");
        return new global::Natrix.StdWeb.HTMLDetailsElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Open
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "open");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "open", value);
    }
}

#nullable disable