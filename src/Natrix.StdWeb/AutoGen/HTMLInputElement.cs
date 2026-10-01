// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLInputElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLInputElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLInputElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLInputElement global::Natrix.JSCore.IJSObjectProxy<HTMLInputElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLInputElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Webkitdirectory
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "webkitdirectory");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "webkitdirectory", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.FileSystemEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemEntry>> WebkitEntries
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.FileSystemEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemEntry>>>.Get(JSObject, "webkitEntries");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Capture
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "capture");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "capture", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLInputElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLInputElement");
        return new global::Natrix.StdWeb.HTMLInputElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Accept
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "accept");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "accept", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Alpha
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "alpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Alt
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "alt");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "alt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Autocomplete
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "autocomplete");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "autocomplete", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DefaultChecked
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "defaultChecked");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "defaultChecked", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Checked
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "checked");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "checked", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ColorSpace
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "colorSpace");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "colorSpace", value);
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
    public global::Natrix.StdWeb.FileList? Files
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.FileList>.Get(JSObject, "files");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.FileList>.Set(JSObject, "files", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FormAction
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "formAction");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "formAction", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FormEnctype
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "formEnctype");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "formEnctype", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FormMethod
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "formMethod");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "formMethod", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool FormNoValidate
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "formNoValidate");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "formNoValidate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FormTarget
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "formTarget");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "formTarget", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Height
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Indeterminate
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "indeterminate");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "indeterminate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLDataListElement? List
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.HTMLDataListElement>.Get(JSObject, "list");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Max
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "max");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "max", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int MaxLength
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "maxLength");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "maxLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Min
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "min");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "min", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int MinLength
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "minLength");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "minLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Multiple
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "multiple");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "multiple", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Pattern
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "pattern");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "pattern", value);
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
    public uint Size
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "size");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "size", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "src");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "src", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Step
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "step");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "step", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
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
    public global::System.Runtime.InteropServices.JavaScript.JSObject? ValueAsDate
    {
        get => global::Natrix.JSCore.Generics.NullableJSObjectAccessor.Get(JSObject, "valueAsDate");
        set => global::Natrix.JSCore.Generics.NullableJSObjectAccessor.Set(JSObject, "valueAsDate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ValueAsNumber
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "valueAsNumber");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "valueAsNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Width
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void StepUp()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "stepUp", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void StepUp(int n)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(n);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "stepUp", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void StepDown()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "stepDown", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void StepDown(int n)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(n);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "stepDown", JSObject, ___argsArray_0.JSObject);
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
    public global::Natrix.StdWeb.NodeList? Labels
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.NodeList>.Get(JSObject, "labels");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Select()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "select", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? SelectionStart
    {
        get => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Get(JSObject, "selectionStart");
        set => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Set(JSObject, "selectionStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? SelectionEnd
    {
        get => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Get(JSObject, "selectionEnd");
        set => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Set(JSObject, "selectionEnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SelectionDirection
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "selectionDirection");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "selectionDirection", value);
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

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void ShowPicker()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "showPicker", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Align
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "align");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "align", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UseMap
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "useMap");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "useMap", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? PopoverTargetElement
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "popoverTargetElement");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Set(JSObject, "popoverTargetElement", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PopoverTargetAction
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "popoverTargetAction");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "popoverTargetAction", value);
    }
}

#nullable disable