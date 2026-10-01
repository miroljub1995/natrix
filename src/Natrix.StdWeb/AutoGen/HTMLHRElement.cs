// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLHRElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLHRElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLHRElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLHRElement global::Natrix.JSCore.IJSObjectProxy<HTMLHRElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLHRElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLHRElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLHRElement");
        return new global::Natrix.StdWeb.HTMLHRElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Align
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "align");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "align", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Color
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "color");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "color", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool NoShade
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "noShade");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "noShade", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Size
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "size");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "size", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Width
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "width", value);
    }
}

#nullable disable