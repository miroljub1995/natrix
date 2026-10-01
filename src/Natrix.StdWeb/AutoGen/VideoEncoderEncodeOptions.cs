// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoEncoderEncodeOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoEncoderEncodeOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoEncoderEncodeOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoEncoderEncodeOptions global::Natrix.JSCore.IJSObjectProxy<VideoEncoderEncodeOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoEncoderEncodeOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAv1 Av1
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAv1>.Get(JSObject, "av1");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAv1>.Set(JSObject, "av1", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAvc Avc
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAvc>.Get(JSObject, "avc");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAvc>.Set(JSObject, "avc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoEncoderEncodeOptionsForHevc Hevc
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForHevc>.Get(JSObject, "hevc");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForHevc>.Set(JSObject, "hevc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoEncoderEncodeOptionsForVp9 Vp9
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForVp9>.Get(JSObject, "vp9");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForVp9>.Set(JSObject, "vp9", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool KeyFrame
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "keyFrame");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "keyFrame", value);
    }
}

#nullable disable