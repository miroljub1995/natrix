// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLOListElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLOListElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLOListElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLOListElement global::Natrix.JSCore.IJSObjectProxy<HTMLOListElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLOListElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLOListElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLOListElement");
        return new global::Natrix.StdWeb.HTMLOListElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Reversed
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "reversed");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "reversed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Start
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "start");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "start", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Compact
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "compact");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "compact", value);
    }
}

#nullable disable