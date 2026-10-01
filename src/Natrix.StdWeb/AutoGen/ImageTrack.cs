// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageTrack: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImageTrack>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageTrack(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImageTrack global::Natrix.JSCore.IJSObjectProxy<ImageTrack>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ImageTrack>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Animated
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "animated");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FrameCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "frameCount");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float RepetitionCount
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "repetitionCount");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Selected
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "selected");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "selected", value);
    }
}

#nullable disable