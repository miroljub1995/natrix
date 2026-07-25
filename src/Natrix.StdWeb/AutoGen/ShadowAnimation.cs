// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ShadowAnimation: global::Natrix.StdWeb.Animation
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ShadowAnimation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ShadowAnimation New(global::Natrix.StdWeb.Animation source, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.GenericMarshaller.Union> newTarget)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = source.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = newTarget.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ShadowAnimation", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ShadowAnimation(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Animation SourceAnimation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Animation, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sourceAnimation");
    }
}

#nullable disable