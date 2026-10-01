// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLFormElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLFormElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLFormElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLFormElement global::Natrix.JSCore.IJSObjectProxy<HTMLFormElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLFormElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLFormElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLFormElement");
        return new global::Natrix.StdWeb.HTMLFormElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AcceptCharset
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "acceptCharset");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "acceptCharset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Action
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "action");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "action", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Autocomplete
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "autocomplete");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "autocomplete", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Enctype
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "enctype");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "enctype", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Encoding
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "encoding");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "encoding", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Method
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "method");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "method", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool NoValidate
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "noValidate");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "noValidate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Target
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "target");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "target", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Rel
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "rel");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "rel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList RelList
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "relList");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLFormControlsCollection Elements
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLFormControlsCollection>.Get(JSObject, "elements");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Length
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "length");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element Get(uint index)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(index);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallGetter(JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RadioNodeList>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>> Get(string name)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = name;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallGetter(JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RadioNodeList>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Submit()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "submit", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RequestSubmit()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "requestSubmit", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RequestSubmit(global::Natrix.StdWeb.HTMLElement? submitter)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_3;
        if (submitter is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLElement ___notNullable_4 = (global::Natrix.StdWeb.HTMLElement)submitter;
            ___marshalledValue_3 = ___notNullable_4.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "requestSubmit", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Reset()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "reset", JSObject);
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
}

#nullable disable