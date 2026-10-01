// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PreferenceObject: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<PreferenceObject>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PreferenceObject(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PreferenceObject global::Natrix.JSCore.IJSObjectProxy<PreferenceObject>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PreferenceObject>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Override
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "override");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Value
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor> ValidValues
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "validValues");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void ClearOverride()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "clearOverride", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise RequestOverride(string? value)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string? ___marshalledValue_3;
        if (value is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            string ___notNullable_4 = (string)value;
            ___marshalledValue_3 = ___notNullable_4;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "requestOverride", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onchange", value);
    }
}

#nullable disable