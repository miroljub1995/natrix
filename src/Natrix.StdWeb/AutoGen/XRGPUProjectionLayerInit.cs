// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRGPUProjectionLayerInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRGPUProjectionLayerInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUProjectionLayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRGPUProjectionLayerInit global::Natrix.JSCore.IJSObjectProxy<XRGPUProjectionLayerInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUProjectionLayerInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUTextureFormat ColorFormat
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Get(JSObject, "colorFormat");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Set(JSObject, "colorFormat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureFormat? DepthStencilFormat
    {
        get => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Get(JSObject, "depthStencilFormat");
        set => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Set(JSObject, "depthStencilFormat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TextureUsage
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "textureUsage");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "textureUsage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScaleFactor
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "scaleFactor");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "scaleFactor", value);
    }
}

#nullable disable