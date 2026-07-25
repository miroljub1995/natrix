// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AnimationEffect: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AnimationEffect(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EffectTiming GetTiming()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getTiming", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EffectTiming, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ComputedEffectTiming GetComputedTiming()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getComputedTiming", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ComputedEffectTiming, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void UpdateTiming()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "updateTiming", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void UpdateTiming(global::Natrix.StdWeb.OptionalEffectTiming timing)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = timing.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "updateTiming", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GroupEffect? Parent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GroupEffect?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "parent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationEffect? PreviousSibling
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AnimationEffect?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "previousSibling");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationEffect? NextSibling
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AnimationEffect?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "nextSibling");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Before(params global::Natrix.StdWeb.AnimationEffect[] effects)
    {
        int ___argsArrayLength_2 = effects.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < effects.Length; ___i_3++)
        {
        global::Natrix.StdWeb.AnimationEffect ___elem_4 = effects[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
            ___marshalledValue_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0 + ___i_3, ___marshalledValue_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "before", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void After(params global::Natrix.StdWeb.AnimationEffect[] effects)
    {
        int ___argsArrayLength_2 = effects.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < effects.Length; ___i_3++)
        {
        global::Natrix.StdWeb.AnimationEffect ___elem_4 = effects[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
            ___marshalledValue_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0 + ___i_3, ___marshalledValue_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "after", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Replace(params global::Natrix.StdWeb.AnimationEffect[] effects)
    {
        int ___argsArrayLength_2 = effects.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < effects.Length; ___i_3++)
        {
        global::Natrix.StdWeb.AnimationEffect ___elem_4 = effects[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
            ___marshalledValue_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0 + ___i_3, ___marshalledValue_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "replace", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Remove()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "remove", JSObject);
    }
}

#nullable disable