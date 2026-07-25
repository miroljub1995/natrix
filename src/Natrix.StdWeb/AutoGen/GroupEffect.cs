// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GroupEffect: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GroupEffect(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.GroupEffect New(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.StdWeb.PropertyAccessor>? children)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_4;
        if (children is null)
        {
            ___propObject_4 = null;
        }
        else
        {
            ___propObject_4 = children.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___propObject_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "GroupEffect", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.GroupEffect(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.GroupEffect New(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.StdWeb.PropertyAccessor>? children, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.EffectTiming, global::Natrix.StdWeb.GenericMarshaller.Union> timing)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_4;
        if (children is null)
        {
            ___propObject_4 = null;
        }
        else
        {
            ___propObject_4 = children.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = timing.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "GroupEffect", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.GroupEffect(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationNodeList Children
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AnimationNodeList, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "children");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationEffect? FirstChild
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AnimationEffect?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "firstChild");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AnimationEffect? LastChild
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AnimationEffect?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "lastChild");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GroupEffect Clone()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "clone", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GroupEffect, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Prepend(params global::Natrix.StdWeb.AnimationEffect[] effects)
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

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "prepend", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Append(params global::Natrix.StdWeb.AnimationEffect[] effects)
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

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "append", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable