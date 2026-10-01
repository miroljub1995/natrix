// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLTextAreaElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLTextAreaElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLTextAreaElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLTextAreaElement global::Natrix.JSCore.IJSObjectProxy<HTMLTextAreaElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLTextAreaElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLTextAreaElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLTextAreaElement");
        return new global::Natrix.StdWeb.HTMLTextAreaElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Autocomplete
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "autocomplete");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "autocomplete", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Cols
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "cols");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "cols", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DirName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "dirName");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "dirName", value);
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
    public int MaxLength
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "maxLength");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "maxLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int MinLength
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "minLength");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "minLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Placeholder
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "placeholder");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "placeholder", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ReadOnly
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "readOnly");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "readOnly", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Required
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "required");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "required", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Rows
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "rows");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "rows", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Wrap
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "wrap");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "wrap", value);
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
    public uint TextLength
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "textLength");
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

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Select()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "select", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SelectionStart
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "selectionStart");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "selectionStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SelectionEnd
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "selectionEnd");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "selectionEnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SelectionDirection
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "selectionDirection");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "selectionDirection", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetRangeText(string replacement)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = replacement;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setRangeText", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetRangeText(string replacement, uint start, uint end)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = replacement;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = Convert.ToDouble(start);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(end);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setRangeText", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetRangeText(string replacement, uint start, uint end, global::Natrix.StdWeb.SelectionMode selectionMode)
    {
        int ___argsArrayLength_2 = 4;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = replacement;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = Convert.ToDouble(start);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(end);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        string ___marshalledValue_6;
        ___marshalledValue_6 = selectionMode.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setRangeText", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetSelectionRange(uint start, uint end)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(start);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = Convert.ToDouble(end);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setSelectionRange", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetSelectionRange(uint start, uint end, string direction)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(start);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = Convert.ToDouble(end);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        string ___marshalledValue_5;
        ___marshalledValue_5 = direction;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setSelectionRange", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable