// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLObjectElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLObjectElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLObjectElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLObjectElement global::Natrix.JSCore.IJSObjectProxy<HTMLObjectElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLObjectElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLObjectElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLObjectElement");
        return new global::Natrix.StdWeb.HTMLObjectElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Data
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "data", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLFormElement? Form
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.HTMLFormElement>.Get(JSObject, "form");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Width
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Height
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "height", value);
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
    public global::Natrix.StdWeb.Document? GetSVGDocument()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getSVGDocument", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Document>.Get(___resOwner_1.JSObject, "value");
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
    public string Align
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "align");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "align", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Archive
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "archive");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "archive", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Code
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "code");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "code", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Declare
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "declare");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "declare", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Hspace
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "hspace");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "hspace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Standby
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "standby");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "standby", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Vspace
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "vspace");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "vspace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CodeBase
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "codeBase");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "codeBase", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CodeType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "codeType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "codeType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UseMap
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "useMap");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "useMap", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Border
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "border");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "border", value);
    }
}

#nullable disable