// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoConfiguration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoConfiguration global::Natrix.JSCore.IJSObjectProxy<VideoConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoConfiguration(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string ContentType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "contentType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "contentType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Width
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Height
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required ulong Bitrate
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bitrate");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bitrate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double Framerate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "framerate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "framerate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasAlphaChannel
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hasAlphaChannel");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "hasAlphaChannel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HdrMetadataType HdrMetadataType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HdrMetadataType>.Get(JSObject, "hdrMetadataType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HdrMetadataType>.Set(JSObject, "hdrMetadataType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ColorGamut ColorGamut
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ColorGamut>.Get(JSObject, "colorGamut");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ColorGamut>.Set(JSObject, "colorGamut", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TransferFunction TransferFunction
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TransferFunction>.Get(JSObject, "transferFunction");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TransferFunction>.Set(JSObject, "transferFunction", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ScalabilityMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "scalabilityMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "scalabilityMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SpatialScalability
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "spatialScalability");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "spatialScalability", value);
    }
}

#nullable disable