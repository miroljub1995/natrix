// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WorkletAnimation: global::Natrix.StdWeb.Animation, global::Natrix.JSCore.IJSObjectProxy<WorkletAnimation>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WorkletAnimation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WorkletAnimation global::Natrix.JSCore.IJSObjectProxy<WorkletAnimation>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WorkletAnimation>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.WorkletAnimation New(string animatorName)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = animatorName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "WorkletAnimation", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.WorkletAnimation(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.WorkletAnimation New(string animatorName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AnimationEffect, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AnimationEffect>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AnimationEffect>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AnimationEffect>>>>? effects)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = animatorName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_5;
        if (effects is null)
        {
            ___propObject_5 = null;
        }
        else
        {
            ___propObject_5 = effects.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 1, ___propObject_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "WorkletAnimation", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.WorkletAnimation(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.WorkletAnimation New(string animatorName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AnimationEffect, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AnimationEffect>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AnimationEffect>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AnimationEffect>>>>? effects, global::Natrix.StdWeb.AnimationTimeline? timeline)
    {
        int ___argsArrayLength_3 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = animatorName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_5;
        if (effects is null)
        {
            ___propObject_5 = null;
        }
        else
        {
            ___propObject_5 = effects.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 1, ___propObject_5);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (timeline is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationTimeline ___notNullable_7 = (global::Natrix.StdWeb.AnimationTimeline)timeline;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 2, ___marshalledValue_6);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "WorkletAnimation", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.WorkletAnimation(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.WorkletAnimation New(string animatorName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.AnimationEffect, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AnimationEffect>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AnimationEffect>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AnimationEffect>>>>? effects, global::Natrix.StdWeb.AnimationTimeline? timeline, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? options)
    {
        int ___argsArrayLength_3 = 4;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = animatorName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_5;
        if (effects is null)
        {
            ___propObject_5 = null;
        }
        else
        {
            ___propObject_5 = effects.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 1, ___propObject_5);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (timeline is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationTimeline ___notNullable_7 = (global::Natrix.StdWeb.AnimationTimeline)timeline;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 2, ___marshalledValue_6);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_8;
        if (options is null)
        {
            ___propObject_8 = null;
        }
        else
        {
            ___propObject_8 = options.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 3, ___propObject_8);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "WorkletAnimation", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.WorkletAnimation(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AnimatorName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "animatorName");
    }
}

#nullable disable