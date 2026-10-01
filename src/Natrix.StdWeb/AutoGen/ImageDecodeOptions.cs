// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageDecodeOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImageDecodeOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageDecodeOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImageDecodeOptions global::Natrix.JSCore.IJSObjectProxy<ImageDecodeOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageDecodeOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FrameIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "frameIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "frameIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CompleteFramesOnly
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "completeFramesOnly");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "completeFramesOnly", value);
    }
}

#nullable disable