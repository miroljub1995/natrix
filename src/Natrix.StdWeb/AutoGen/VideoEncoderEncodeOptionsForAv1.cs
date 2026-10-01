// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoEncoderEncodeOptionsForAv1: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoEncoderEncodeOptionsForAv1>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoEncoderEncodeOptionsForAv1(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoEncoderEncodeOptionsForAv1 global::Natrix.JSCore.IJSObjectProxy<VideoEncoderEncodeOptionsForAv1>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoEncoderEncodeOptionsForAv1(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? Quantizer
    {
        get => global::Natrix.JSCore.Generics.NullableUInt16Accessor.Get(JSObject, "quantizer");
        set => global::Natrix.JSCore.Generics.NullableUInt16Accessor.Set(JSObject, "quantizer", value);
    }
}

#nullable disable