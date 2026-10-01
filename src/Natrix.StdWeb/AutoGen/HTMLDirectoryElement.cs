// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLDirectoryElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLDirectoryElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLDirectoryElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLDirectoryElement global::Natrix.JSCore.IJSObjectProxy<HTMLDirectoryElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLDirectoryElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLDirectoryElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLDirectoryElement");
        return new global::Natrix.StdWeb.HTMLDirectoryElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Compact
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "compact");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "compact", value);
    }
}

#nullable disable