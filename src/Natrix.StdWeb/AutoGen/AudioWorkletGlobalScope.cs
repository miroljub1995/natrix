// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioWorkletGlobalScope: global::Natrix.StdWeb.WorkletGlobalScope
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioWorkletGlobalScope(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RegisterProcessor(string name, global::Natrix.StdWeb.AudioWorkletProcessorConstructor processorCtor)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = name;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = processorCtor.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "registerProcessor", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong CurrentFrame
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "currentFrame");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CurrentTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "currentTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float SampleRate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sampleRate");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RenderQuantumSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "renderQuantumSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MessagePort Port
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "port");
    }
}

#nullable disable