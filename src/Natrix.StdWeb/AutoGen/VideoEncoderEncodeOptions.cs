// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoEncoderEncodeOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoEncoderEncodeOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoEncoderEncodeOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAvc Avc
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAvc, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "avc");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAvc, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "avc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool KeyFrame
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "keyFrame");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "keyFrame", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAv1 Av1
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAv1, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "av1");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForAv1, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "av1", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoEncoderEncodeOptionsForHevc Hevc
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForHevc, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hevc");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForHevc, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hevc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoEncoderEncodeOptionsForVp9 Vp9
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForVp9, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vp9");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoEncoderEncodeOptionsForVp9, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vp9", value);
    }
}

#nullable disable