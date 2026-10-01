// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLScriptElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLScriptElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLScriptElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLScriptElement global::Natrix.JSCore.IJSObjectProxy<HTMLScriptElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLScriptElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLScriptElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLScriptElement");
        return new global::Natrix.StdWeb.HTMLScriptElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "src");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "src", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool NoModule
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "noModule");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "noModule", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Async
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "async");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "async", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Defer
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "defer");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "defer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList Blocking
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "blocking");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? CrossOrigin
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "crossOrigin");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "crossOrigin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ReferrerPolicy
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "referrerPolicy");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "referrerPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Integrity
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "integrity");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "integrity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FetchPriority
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "fetchPriority");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "fetchPriority", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Text
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "text");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "text", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static bool Supports(string type)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLScriptElement"), "supports", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLScriptElement"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Charset
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "charset");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "charset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Event
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "event");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "event", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string HtmlFor
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "htmlFor");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "htmlFor", value);
    }
}

#nullable disable