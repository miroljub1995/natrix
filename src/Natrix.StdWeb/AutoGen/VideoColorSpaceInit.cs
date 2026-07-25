// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoColorSpaceInit: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoColorSpaceInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoColorSpaceInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoColorPrimaries? Primaries
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoColorPrimaries?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "primaries");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoColorPrimaries?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "primaries", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoTransferCharacteristics? Transfer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoTransferCharacteristics?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "transfer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoTransferCharacteristics?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "transfer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoMatrixCoefficients? Matrix
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoMatrixCoefficients?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "matrix");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoMatrixCoefficients?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "matrix", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool? FullRange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "fullRange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "fullRange", value);
    }
}

#nullable disable