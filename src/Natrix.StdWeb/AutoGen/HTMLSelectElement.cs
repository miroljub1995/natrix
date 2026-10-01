// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLSelectElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLSelectElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLSelectElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLSelectElement global::Natrix.JSCore.IJSObjectProxy<HTMLSelectElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLSelectElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLSelectElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLSelectElement");
        return new global::Natrix.StdWeb.HTMLSelectElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Autocomplete
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "autocomplete");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "autocomplete", value);
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
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLOptionsCollection Options
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLOptionsCollection>.Get(JSObject, "options");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Length
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "length");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "length", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLOptionElement? Item(uint index)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(index);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "item", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.HTMLOptionElement>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLOptionElement? NamedItem(string name)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = name;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "namedItem", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.HTMLOptionElement>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Add(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLOptionElement, global::Natrix.StdWeb.HTMLOptGroupElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLOptionElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLOptGroupElement>> element)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = element.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "add", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Add(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLOptionElement, global::Natrix.StdWeb.HTMLOptGroupElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLOptionElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLOptGroupElement>> element, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLElement, int, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLElement>, global::Natrix.JSCore.Generics.Int32Accessor>? before)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = element.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_4;
        if (before is null)
        {
            ___propObject_4 = null;
        }
        else
        {
            ___propObject_4 = before.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 1, ___propObject_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "add", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Remove()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "remove", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Remove(int index)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(index);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "remove", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Set(uint index, global::Natrix.StdWeb.HTMLOptionElement? option)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(index);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_4;
        if (option is null)
        {
            ___marshalledValue_4 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLOptionElement ___notNullable_5 = (global::Natrix.StdWeb.HTMLOptionElement)option;
            ___marshalledValue_4 = ___notNullable_5.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallSetter(JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLCollection SelectedOptions
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCollection>.Get(JSObject, "selectedOptions");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int SelectedIndex
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "selectedIndex");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "selectedIndex", value);
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
    public void ShowPicker()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "showPicker", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NodeList Labels
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NodeList>.Get(JSObject, "labels");
    }
}

#nullable disable