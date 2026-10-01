// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoFrameBufferInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoFrameBufferInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoFrameBufferInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoFrameBufferInit global::Natrix.JSCore.IJSObjectProxy<VideoFrameBufferInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoFrameBufferInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.VideoPixelFormat Format
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.VideoPixelFormat>.Get(JSObject, "format");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.VideoPixelFormat>.Set(JSObject, "format", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint CodedWidth
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "codedWidth");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "codedWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint CodedHeight
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "codedHeight");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "codedHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required long Timestamp
    {
        get => global::Natrix.JSCore.Generics.Int64Accessor.Get(JSObject, "timestamp");
        set => global::Natrix.JSCore.Generics.Int64Accessor.Set(JSObject, "timestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Duration
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "duration");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "duration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PlaneLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PlaneLayout>> Layout
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PlaneLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PlaneLayout>>>.Get(JSObject, "layout");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PlaneLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PlaneLayout>>>.Set(JSObject, "layout", value);
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
    public global::Natrix.StdWeb.VideoColorSpaceInit ColorSpace
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoColorSpaceInit>.Get(JSObject, "colorSpace");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoColorSpaceInit>.Set(JSObject, "colorSpace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.ArrayBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>> Transfer
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.ArrayBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>>>.Get(JSObject, "transfer");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.ArrayBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>>>.Set(JSObject, "transfer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoFrameMetadata Metadata
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoFrameMetadata>.Get(JSObject, "metadata");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoFrameMetadata>.Set(JSObject, "metadata", value);
    }
}

#nullable disable