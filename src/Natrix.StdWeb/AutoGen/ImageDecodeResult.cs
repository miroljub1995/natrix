// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageDecodeResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImageDecodeResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageDecodeResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImageDecodeResult global::Natrix.JSCore.IJSObjectProxy<ImageDecodeResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageDecodeResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.VideoFrame Image
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoFrame>.Get(JSObject, "image");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoFrame>.Set(JSObject, "image", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool Complete
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "complete");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "complete", value);
    }
}

#nullable disable