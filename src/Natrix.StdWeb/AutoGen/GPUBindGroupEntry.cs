// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBindGroupEntry: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUBindGroupEntry>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBindGroupEntry(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUBindGroupEntry global::Natrix.JSCore.IJSObjectProxy<GPUBindGroupEntry>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBindGroupEntry(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Binding
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "binding");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "binding", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUSampler, global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.StdWeb.GPUBuffer, global::Natrix.StdWeb.GPUBufferBinding, global::Natrix.StdWeb.GPUExternalTexture, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUSampler>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBufferBinding>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUExternalTexture>> Resource
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUSampler, global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.StdWeb.GPUBuffer, global::Natrix.StdWeb.GPUBufferBinding, global::Natrix.StdWeb.GPUExternalTexture, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUSampler>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBufferBinding>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUExternalTexture>>>.Get(JSObject, "resource");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUSampler, global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.StdWeb.GPUBuffer, global::Natrix.StdWeb.GPUBufferBinding, global::Natrix.StdWeb.GPUExternalTexture, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUSampler>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBufferBinding>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUExternalTexture>>>.Set(JSObject, "resource", value);
    }
}

#nullable disable