// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLOptionElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLOptionElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLOptionElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLOptionElement global::Natrix.JSCore.IJSObjectProxy<HTMLOptionElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLOptionElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLOptionElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLOptionElement");
        return new global::Natrix.StdWeb.HTMLOptionElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Disabled
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "disabled");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "disabled", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLFormElement? Form
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.HTMLFormElement>.Get(JSObject, "form");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "label", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DefaultSelected
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "defaultSelected");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "defaultSelected", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Selected
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "selected");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "selected", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Value
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Text
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "text");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "text", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Index
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "index");
    }
}

#nullable disable