// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AnimationTimeline: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AnimationTimeline>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AnimationTimeline(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AnimationTimeline global::Natrix.JSCore.IJSObjectProxy<AnimationTimeline>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AnimationTimeline>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>? CurrentTime
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>>.Get(JSObject, "currentTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>? Duration
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>>.Get(JSObject, "duration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Animation Play()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "play", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Animation>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Animation Play(global::Natrix.StdWeb.AnimationEffect? effect)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_3;
        if (effect is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationEffect ___notNullable_4 = (global::Natrix.StdWeb.AnimationEffect)effect;
            ___marshalledValue_3 = ___notNullable_4.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "play", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Animation>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable