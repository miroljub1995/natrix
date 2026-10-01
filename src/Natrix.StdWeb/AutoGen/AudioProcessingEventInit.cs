// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioProcessingEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<AudioProcessingEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioProcessingEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioProcessingEventInit global::Natrix.JSCore.IJSObjectProxy<AudioProcessingEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioProcessingEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double PlaybackTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "playbackTime");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "playbackTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.AudioBuffer InputBuffer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AudioBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioBuffer>>(JSObject, "inputBuffer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AudioBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioBuffer>>(JSObject, "inputBuffer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.AudioBuffer OutputBuffer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AudioBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioBuffer>>(JSObject, "outputBuffer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AudioBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioBuffer>>(JSObject, "outputBuffer", value);
    }
}

#nullable disable