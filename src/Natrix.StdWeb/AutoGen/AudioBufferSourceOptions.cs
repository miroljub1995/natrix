// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioBufferSourceOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioBufferSourceOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioBufferSourceOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioBufferSourceOptions global::Natrix.JSCore.IJSObjectProxy<AudioBufferSourceOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioBufferSourceOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioBuffer? Buffer
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AudioBuffer>.Get(JSObject, "buffer");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AudioBuffer>.Set(JSObject, "buffer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Detune
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "detune");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "detune", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Loop
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "loop");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "loop", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LoopEnd
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "loopEnd");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "loopEnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LoopStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "loopStart");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "loopStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float PlaybackRate
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "playbackRate");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "playbackRate", value);
    }
}

#nullable disable