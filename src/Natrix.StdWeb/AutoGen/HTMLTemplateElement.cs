// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLTemplateElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLTemplateElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLTemplateElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLTemplateElement global::Natrix.JSCore.IJSObjectProxy<HTMLTemplateElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLTemplateElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLTemplateElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLTemplateElement");
        return new global::Natrix.StdWeb.HTMLTemplateElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DocumentFragment Content
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DocumentFragment>.Get(JSObject, "content");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ShadowRootMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "shadowRootMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "shadowRootMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ShadowRootDelegatesFocus
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "shadowRootDelegatesFocus");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "shadowRootDelegatesFocus", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ShadowRootSlotAssignment
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "shadowRootSlotAssignment");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "shadowRootSlotAssignment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ShadowRootClonable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "shadowRootClonable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "shadowRootClonable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ShadowRootSerializable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "shadowRootSerializable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "shadowRootSerializable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ShadowRootCustomElementRegistry
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "shadowRootCustomElementRegistry");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "shadowRootCustomElementRegistry", value);
    }
}

#nullable disable