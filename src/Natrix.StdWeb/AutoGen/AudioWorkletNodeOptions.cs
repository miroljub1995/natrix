// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioWorkletNodeOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<AudioWorkletNodeOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioWorkletNodeOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioWorkletNodeOptions global::Natrix.JSCore.IJSObjectProxy<AudioWorkletNodeOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioWorkletNodeOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NumberOfInputs
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "numberOfInputs");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "numberOfInputs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NumberOfOutputs
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "numberOfOutputs");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "numberOfOutputs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor> OutputChannelCount
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>.Get(JSObject, "outputChannelCount");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>.Set(JSObject, "outputChannelCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor> ParameterData
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Get(JSObject, "parameterData");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Set(JSObject, "parameterData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ProcessorOptions
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "processorOptions");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "processorOptions", value);
    }
}

#nullable disable