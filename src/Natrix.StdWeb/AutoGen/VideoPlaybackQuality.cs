// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoPlaybackQuality: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoPlaybackQuality(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CreationTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "creationTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DroppedVideoFrames
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "droppedVideoFrames");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TotalVideoFrames
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "totalVideoFrames");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CorruptedVideoFrames
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "corruptedVideoFrames");
    }
}

#nullable disable