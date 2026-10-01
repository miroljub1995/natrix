// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoColorSpaceInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoColorSpaceInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoColorSpaceInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoColorSpaceInit global::Natrix.JSCore.IJSObjectProxy<VideoColorSpaceInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoColorSpaceInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoColorPrimaries? Primaries
    {
        get => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoColorPrimaries>.Get(JSObject, "primaries");
        set => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoColorPrimaries>.Set(JSObject, "primaries", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoTransferCharacteristics? Transfer
    {
        get => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoTransferCharacteristics>.Get(JSObject, "transfer");
        set => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoTransferCharacteristics>.Set(JSObject, "transfer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoMatrixCoefficients? Matrix
    {
        get => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoMatrixCoefficients>.Get(JSObject, "matrix");
        set => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoMatrixCoefficients>.Set(JSObject, "matrix", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool? FullRange
    {
        get => global::Natrix.JSCore.Generics.NullableBooleanAccessor.Get(JSObject, "fullRange");
        set => global::Natrix.JSCore.Generics.NullableBooleanAccessor.Set(JSObject, "fullRange", value);
    }
}

#nullable disable