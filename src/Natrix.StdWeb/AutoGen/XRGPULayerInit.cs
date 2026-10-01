// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRGPULayerInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRGPULayerInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPULayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRGPULayerInit global::Natrix.JSCore.IJSObjectProxy<XRGPULayerInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPULayerInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
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
    public required global::Natrix.StdWeb.XRSpace Space
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>.Get(JSObject, "space");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>.Set(JSObject, "space", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MipLevels
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "mipLevels");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "mipLevels", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint ViewPixelWidth
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "viewPixelWidth");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "viewPixelWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint ViewPixelHeight
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "viewPixelHeight");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "viewPixelHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRLayerLayout Layout
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRLayerLayout>.Get(JSObject, "layout");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRLayerLayout>.Set(JSObject, "layout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsStatic
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isStatic");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isStatic", value);
    }
}

#nullable disable