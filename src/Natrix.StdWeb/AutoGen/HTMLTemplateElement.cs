// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLTemplateElement: global::Natrix.StdWeb.HTMLElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLTemplateElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLTemplateElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLTemplateElement");
        return new global::Natrix.StdWeb.HTMLTemplateElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DocumentFragment Content
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DocumentFragment, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "content");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ShadowRootMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ShadowRootDelegatesFocus
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootDelegatesFocus");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootDelegatesFocus", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ShadowRootSlotAssignment
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootSlotAssignment");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootSlotAssignment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ShadowRootClonable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootClonable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootClonable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ShadowRootSerializable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootSerializable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootSerializable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ShadowRootCustomElementRegistry
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootCustomElementRegistry");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shadowRootCustomElementRegistry", value);
    }
}

#nullable disable