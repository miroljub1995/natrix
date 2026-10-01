// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLFrameElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLFrameElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLFrameElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLFrameElement global::Natrix.JSCore.IJSObjectProxy<HTMLFrameElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLFrameElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLFrameElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLFrameElement");
        return new global::Natrix.StdWeb.HTMLFrameElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Scrolling
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "scrolling");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "scrolling", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "src");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "src", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FrameBorder
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "frameBorder");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "frameBorder", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LongDesc
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "longDesc");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "longDesc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool NoResize
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "noResize");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "noResize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Document? ContentDocument
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Document>.Get(JSObject, "contentDocument");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Window? ContentWindow
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Window>.Get(JSObject, "contentWindow");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MarginHeight
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "marginHeight");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "marginHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MarginWidth
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "marginWidth");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "marginWidth", value);
    }
}

#nullable disable