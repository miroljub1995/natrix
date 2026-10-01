// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoPlaybackQuality: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoPlaybackQuality>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoPlaybackQuality(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoPlaybackQuality global::Natrix.JSCore.IJSObjectProxy<VideoPlaybackQuality>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<VideoPlaybackQuality>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CreationTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "creationTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DroppedVideoFrames
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "droppedVideoFrames");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TotalVideoFrames
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "totalVideoFrames");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CorruptedVideoFrames
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "corruptedVideoFrames");
    }
}

#nullable disable