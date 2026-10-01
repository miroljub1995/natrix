// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ConvolverNode: global::Natrix.StdWeb.AudioNode, global::Natrix.JSCore.IJSObjectProxy<ConvolverNode>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConvolverNode(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ConvolverNode global::Natrix.JSCore.IJSObjectProxy<ConvolverNode>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ConvolverNode>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ConvolverNode New(global::Natrix.StdWeb.BaseAudioContext context)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = context.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ConvolverNode", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ConvolverNode(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ConvolverNode New(global::Natrix.StdWeb.BaseAudioContext context, global::Natrix.StdWeb.ConvolverOptions options)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = context.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ConvolverNode", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ConvolverNode(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioBuffer? Buffer
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AudioBuffer>.Get(JSObject, "buffer");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AudioBuffer>.Set(JSObject, "buffer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Normalize
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "normalize");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "normalize", value);
    }
}

#nullable disable