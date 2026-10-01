// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioBufferSourceNode: global::Natrix.StdWeb.AudioScheduledSourceNode, global::Natrix.JSCore.IJSObjectProxy<AudioBufferSourceNode>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioBufferSourceNode(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioBufferSourceNode global::Natrix.JSCore.IJSObjectProxy<AudioBufferSourceNode>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AudioBufferSourceNode>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.AudioBufferSourceNode New(global::Natrix.StdWeb.BaseAudioContext context)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = context.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "AudioBufferSourceNode", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.AudioBufferSourceNode(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.AudioBufferSourceNode New(global::Natrix.StdWeb.BaseAudioContext context, global::Natrix.StdWeb.AudioBufferSourceOptions options)
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

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "AudioBufferSourceNode", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.AudioBufferSourceNode(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioBuffer? Buffer
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AudioBuffer>.Get(JSObject, "buffer");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AudioBuffer>.Set(JSObject, "buffer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioParam PlaybackRate
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioParam>.Get(JSObject, "playbackRate");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioParam Detune
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioParam>.Get(JSObject, "detune");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Loop
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "loop");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "loop", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LoopStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "loopStart");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "loopStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LoopEnd
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "loopEnd");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "loopEnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Start()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "start", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Start(double when)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = when;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "start", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Start(double when, double offset)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = when;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = offset;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "start", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Start(double when, double offset, double duration)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = when;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = offset;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        double ___marshalledValue_5;
        ___marshalledValue_5 = duration;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "start", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable