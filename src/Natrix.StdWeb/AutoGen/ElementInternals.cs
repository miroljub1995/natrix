// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ElementInternals: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ElementInternals>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ElementInternals(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ElementInternals global::Natrix.JSCore.IJSObjectProxy<ElementInternals>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ElementInternals>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ShadowRoot? ShadowRoot
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ShadowRoot>.Get(JSObject, "shadowRoot");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetFormValue(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.FormData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.File>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FormData>>? value)
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
    public void SetFormValue(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.FormData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.File>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FormData>>? value, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.FormData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.File>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FormData>>? state)
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
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.HTMLFormElement>.Get(JSObject, "form");
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
    public global::Natrix.StdWeb.NodeList Labels
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NodeList>.Get(JSObject, "labels");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CustomStateSet States
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CustomStateSet>.Get(JSObject, "states");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Role
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "role");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "role", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? AriaActiveDescendantElement
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "ariaActiveDescendantElement");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Set(JSObject, "ariaActiveDescendantElement", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaAtomic
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaAtomic");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaAtomic", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaAutoComplete
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaAutoComplete");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaAutoComplete", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaBrailleLabel
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaBrailleLabel");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaBrailleLabel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaBrailleRoleDescription
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaBrailleRoleDescription");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaBrailleRoleDescription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaBusy
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaBusy");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaBusy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaChecked
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaChecked");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaChecked", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColCount
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaColCount");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaColCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColIndex
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaColIndex");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaColIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColIndexText
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaColIndexText");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaColIndexText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColSpan
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaColSpan");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaColSpan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaControlsElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaControlsElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaControlsElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaCurrent
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaCurrent");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaCurrent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaDescribedByElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaDescribedByElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaDescribedByElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaDescription
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaDescription");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaDescription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaDetailsElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaDetailsElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaDetailsElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaDisabled
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaDisabled");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaDisabled", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaErrorMessageElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaErrorMessageElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaErrorMessageElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaExpanded
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaExpanded");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaExpanded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaFlowToElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaFlowToElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaFlowToElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaHasPopup
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaHasPopup");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaHasPopup", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaHidden
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaHidden");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaHidden", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaInvalid
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaInvalid");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaInvalid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaKeyShortcuts
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaKeyShortcuts");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaKeyShortcuts", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaLabel
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaLabel");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaLabel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaLabelledByElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaLabelledByElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaLabelledByElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaLevel
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaLevel");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaLevel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaLive
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaLive");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaLive", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaModal
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaModal");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaModal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaMultiLine
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaMultiLine");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaMultiLine", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaMultiSelectable
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaMultiSelectable");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaMultiSelectable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaOrientation
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaOrientation");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaOrientation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaOwnsElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaOwnsElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaOwnsElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaPlaceholder
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaPlaceholder");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaPlaceholder", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaPosInSet
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaPosInSet");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaPosInSet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaPressed
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaPressed");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaPressed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaReadOnly
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaReadOnly");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaReadOnly", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRelevant
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRelevant");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRelevant", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRequired
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRequired");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRequired", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRoleDescription
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRoleDescription");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRoleDescription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowCount
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRowCount");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRowCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowIndex
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRowIndex");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRowIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowIndexText
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRowIndexText");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRowIndexText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowSpan
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRowSpan");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRowSpan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaSelected
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaSelected");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaSelected", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaSetSize
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaSetSize");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaSetSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaSort
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaSort");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaSort", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueMax
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaValueMax");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaValueMax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueMin
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaValueMin");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaValueMin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueNow
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaValueNow");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaValueNow", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueText
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaValueText");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaValueText", value);
    }
}

#nullable disable