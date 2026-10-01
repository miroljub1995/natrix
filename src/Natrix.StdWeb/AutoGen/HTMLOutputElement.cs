// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLOutputElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLOutputElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLOutputElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLOutputElement global::Natrix.JSCore.IJSObjectProxy<HTMLOutputElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLOutputElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLOutputElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLOutputElement");
        return new global::Natrix.StdWeb.HTMLOutputElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList HtmlFor
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "htmlFor");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLFormElement? Form
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.HTMLFormElement>.Get(JSObject, "form");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DefaultValue
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "defaultValue");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "defaultValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Value
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool WillValidate
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "willValidate");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ValidityState Validity
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ValidityState>.Get(JSObject, "validity");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ValidationMessage
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "validationMessage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CheckValidity()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "checkValidity", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ReportValidity()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "reportValidity", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetCustomValidity(string error)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = error;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setCustomValidity", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NodeList Labels
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NodeList>.Get(JSObject, "labels");
    }
}

#nullable disable