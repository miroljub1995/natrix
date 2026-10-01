// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPURenderPassLayout: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPURenderPassLayout>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPassLayout(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPURenderPassLayout global::Natrix.JSCore.IJSObjectProxy<GPURenderPassLayout>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPassLayout(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>> ColorFormats
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>>>.Get(JSObject, "colorFormats");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>>>.Set(JSObject, "colorFormats", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureFormat DepthStencilFormat
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Get(JSObject, "depthStencilFormat");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Set(JSObject, "depthStencilFormat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SampleCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "sampleCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "sampleCount", value);
    }
}

#nullable disable