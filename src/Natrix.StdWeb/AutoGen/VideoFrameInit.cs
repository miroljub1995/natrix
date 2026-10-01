// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoFrameInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoFrameInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoFrameInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoFrameInit global::Natrix.JSCore.IJSObjectProxy<VideoFrameInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoFrameInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Duration
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "duration");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "duration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long Timestamp
    {
        get => global::Natrix.JSCore.Generics.Int64Accessor.Get(JSObject, "timestamp");
        set => global::Natrix.JSCore.Generics.Int64Accessor.Set(JSObject, "timestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AlphaOption Alpha
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AlphaOption>.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AlphaOption>.Set(JSObject, "alpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectInit VisibleRect
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectInit>.Get(JSObject, "visibleRect");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectInit>.Set(JSObject, "visibleRect", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Rotation
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "rotation");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "rotation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Flip
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "flip");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "flip", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DisplayWidth
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "displayWidth");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "displayWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DisplayHeight
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "displayHeight");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "displayHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoFrameMetadata Metadata
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoFrameMetadata>.Get(JSObject, "metadata");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoFrameMetadata>.Set(JSObject, "metadata", value);
    }
}

#nullable disable