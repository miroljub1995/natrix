// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ElementInternals: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ElementInternals(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ShadowRoot? ShadowRoot
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ShadowRoot?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "shadowRoot");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetFormValue(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_3;
        if (value is null)
        {
            ___propObject_3 = null;
        }
        else
        {
            ___propObject_3 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 0, ___propObject_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setFormValue", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetFormValue(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.GenericMarshaller.Union>? value, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.GenericMarshaller.Union>? state)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_3;
        if (value is null)
        {
            ___propObject_3 = null;
        }
        else
        {
            ___propObject_3 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_4;
        if (state is null)
        {
            ___propObject_4 = null;
        }
        else
        {
            ___propObject_4 = state.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 1, ___propObject_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setFormValue", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLFormElement? Form
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.HTMLFormElement?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "form");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetValidity()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "setValidity", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetValidity(global::Natrix.StdWeb.ValidityStateFlags flags)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = flags.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setValidity", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetValidity(global::Natrix.StdWeb.ValidityStateFlags flags, string message)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = flags.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = message;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setValidity", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetValidity(global::Natrix.StdWeb.ValidityStateFlags flags, string message, global::Natrix.StdWeb.HTMLElement anchor)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = flags.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = message;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = anchor.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setValidity", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool WillValidate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "willValidate");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ValidityState Validity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ValidityState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "validity");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ValidationMessage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "validationMessage");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CheckValidity()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "checkValidity", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ReportValidity()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "reportValidity", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NodeList Labels
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NodeList, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "labels");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CustomStateSet States
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CustomStateSet, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "states");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Role
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "role");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "role", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? AriaActiveDescendantElement
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Element?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaActiveDescendantElement");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.Element?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaActiveDescendantElement", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaAtomic
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaAtomic");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaAtomic", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaAutoComplete
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaAutoComplete");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaAutoComplete", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaBrailleLabel
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaBrailleLabel");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaBrailleLabel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaBrailleRoleDescription
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaBrailleRoleDescription");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaBrailleRoleDescription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaBusy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaBusy");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaBusy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaChecked
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaChecked");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaChecked", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaColCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaColCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColIndex
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaColIndex");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaColIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColIndexText
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaColIndexText");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaColIndexText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColSpan
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaColSpan");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaColSpan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? AriaControlsElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaControlsElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaControlsElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaCurrent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaCurrent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaCurrent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? AriaDescribedByElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaDescribedByElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaDescribedByElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaDescription
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaDescription");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaDescription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? AriaDetailsElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaDetailsElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaDetailsElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaDisabled
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaDisabled");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaDisabled", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? AriaErrorMessageElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaErrorMessageElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaErrorMessageElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaExpanded
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaExpanded");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaExpanded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? AriaFlowToElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaFlowToElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaFlowToElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaHasPopup
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaHasPopup");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaHasPopup", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaHidden
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaHidden");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaHidden", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaInvalid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaInvalid");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaInvalid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaKeyShortcuts
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaKeyShortcuts");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaKeyShortcuts", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaLabel
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaLabel");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaLabel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? AriaLabelledByElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaLabelledByElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaLabelledByElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaLevel
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaLevel");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaLevel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaLive
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaLive");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaLive", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaModal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaModal");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaModal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaMultiLine
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaMultiLine");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaMultiLine", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaMultiSelectable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaMultiSelectable");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaMultiSelectable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaOrientation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaOrientation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaOrientation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? AriaOwnsElements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaOwnsElements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaOwnsElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaPlaceholder
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaPlaceholder");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaPlaceholder", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaPosInSet
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaPosInSet");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaPosInSet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaPressed
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaPressed");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaPressed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaReadOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaReadOnly");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaReadOnly", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRelevant
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRelevant");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRelevant", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRequired
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRequired");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRequired", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRoleDescription
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRoleDescription");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRoleDescription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRowCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRowCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowIndex
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRowIndex");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRowIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowIndexText
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRowIndexText");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRowIndexText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowSpan
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRowSpan");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaRowSpan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaSelected
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaSelected");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaSelected", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaSetSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaSetSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaSetSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaSort
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaSort");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaSort", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueMax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaValueMax");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaValueMax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueMin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaValueMin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaValueMin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueNow
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaValueNow");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaValueNow", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueText
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaValueText");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "ariaValueText", value);
    }
}

#nullable disable