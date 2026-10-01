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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoColorPrimaries?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoColorPrimaries>>(JSObject, "primaries");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoColorPrimaries?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoColorPrimaries>>(JSObject, "primaries", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoTransferCharacteristics? Transfer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoTransferCharacteristics?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoTransferCharacteristics>>(JSObject, "transfer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoTransferCharacteristics?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoTransferCharacteristics>>(JSObject, "transfer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoMatrixCoefficients? Matrix
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoMatrixCoefficients?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoMatrixCoefficients>>(JSObject, "matrix");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoMatrixCoefficients?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.VideoMatrixCoefficients>>(JSObject, "matrix", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool? FullRange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool?, global::Natrix.JSCore.Generics.NullableBooleanAccessor>(JSObject, "fullRange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool?, global::Natrix.JSCore.Generics.NullableBooleanAccessor>(JSObject, "fullRange", value);
    }
}

#nullable disable