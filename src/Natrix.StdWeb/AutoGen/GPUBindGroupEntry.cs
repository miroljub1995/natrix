// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBindGroupEntry: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBindGroupEntry(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBindGroupEntry(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Binding
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "binding");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "binding", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUSampler, global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.StdWeb.GPUBuffer, global::Natrix.StdWeb.GPUBufferBinding, global::Natrix.StdWeb.GPUExternalTexture, global::Natrix.StdWeb.GenericMarshaller.Union> Resource
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUSampler, global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.StdWeb.GPUBuffer, global::Natrix.StdWeb.GPUBufferBinding, global::Natrix.StdWeb.GPUExternalTexture, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "resource");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUSampler, global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.StdWeb.GPUBuffer, global::Natrix.StdWeb.GPUBufferBinding, global::Natrix.StdWeb.GPUExternalTexture, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "resource", value);
    }
}

#nullable disable