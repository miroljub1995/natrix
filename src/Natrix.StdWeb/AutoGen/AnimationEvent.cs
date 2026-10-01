// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AnimationEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<AnimationEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AnimationEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AnimationEvent global::Natrix.JSCore.IJSObjectProxy<AnimationEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AnimationEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.AnimationEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "AnimationEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.AnimationEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.AnimationEvent New(string type, global::Natrix.StdWeb.AnimationEventInit animationEventInitDict)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = animationEventInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "AnimationEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.AnimationEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AnimationName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "animationName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ElapsedTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "elapsedTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PseudoElement
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "pseudoElement");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSAnimation? Animation
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CSSAnimation>.Get(JSObject, "animation");
    }
}

#nullable disable