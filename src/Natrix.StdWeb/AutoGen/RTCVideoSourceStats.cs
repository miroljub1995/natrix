// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCVideoSourceStats: global::Natrix.StdWeb.RTCMediaSourceStats, global::Natrix.JSCore.IJSObjectProxy<RTCVideoSourceStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCVideoSourceStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCVideoSourceStats global::Natrix.JSCore.IJSObjectProxy<RTCVideoSourceStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCVideoSourceStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Width
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Height
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Frames
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "frames");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "frames", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FramesPerSecond
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "framesPerSecond");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "framesPerSecond", value);
    }
}

#nullable disable