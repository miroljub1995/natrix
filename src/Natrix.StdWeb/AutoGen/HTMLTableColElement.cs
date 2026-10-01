// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLTableColElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLTableColElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLTableColElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLTableColElement global::Natrix.JSCore.IJSObjectProxy<HTMLTableColElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLTableColElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLTableColElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLTableColElement");
        return new global::Natrix.StdWeb.HTMLTableColElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Span
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "span");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "span", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Align
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "align");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "align", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Ch
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "ch");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "ch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ChOff
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "chOff");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "chOff", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string VAlign
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "vAlign");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "vAlign", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Width
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "width", value);
    }
}

#nullable disable