// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPURenderPassLayout: global::Natrix.StdWeb.GPUObjectDescriptorBase
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPassLayout(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPassLayout(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat?, global::Natrix.StdWeb.PropertyAccessorNullable> ColorFormats
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "colorFormats");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "colorFormats", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureFormat DepthStencilFormat
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "depthStencilFormat");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "depthStencilFormat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SampleCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sampleCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sampleCount", value);
    }
}

#nullable disable