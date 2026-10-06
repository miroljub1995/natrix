// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoFrameMetadata: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoFrameMetadata>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoFrameMetadata(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoFrameMetadata global::Natrix.JSCore.IJSObjectProxy<VideoFrameMetadata>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoFrameMetadata(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Segment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Segment>> Segments
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Segment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Segment>>>.Get(JSObject, "segments");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Segment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Segment>>>.Set(JSObject, "segments", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BackgroundBlur BackgroundBlur
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundBlur>.Get(JSObject, "backgroundBlur");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundBlur>.Set(JSObject, "backgroundBlur", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ImageBitmap BackgroundSegmentationMask
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageBitmap>.Get(JSObject, "backgroundSegmentationMask");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageBitmap>.Set(JSObject, "backgroundSegmentationMask", value);
    }
}

#nullable disable