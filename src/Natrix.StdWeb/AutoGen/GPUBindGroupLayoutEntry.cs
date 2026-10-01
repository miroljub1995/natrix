// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBindGroupLayoutEntry: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUBindGroupLayoutEntry>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBindGroupLayoutEntry(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUBindGroupLayoutEntry global::Natrix.JSCore.IJSObjectProxy<GPUBindGroupLayoutEntry>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBindGroupLayoutEntry(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Binding
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "binding");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "binding", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Visibility
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "visibility");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "visibility", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUBufferBindingLayout Buffer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUBufferBindingLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBufferBindingLayout>>(JSObject, "buffer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUBufferBindingLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBufferBindingLayout>>(JSObject, "buffer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUSamplerBindingLayout Sampler
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUSamplerBindingLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUSamplerBindingLayout>>(JSObject, "sampler");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUSamplerBindingLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUSamplerBindingLayout>>(JSObject, "sampler", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureBindingLayout Texture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureBindingLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureBindingLayout>>(JSObject, "texture");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUTextureBindingLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureBindingLayout>>(JSObject, "texture", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStorageTextureBindingLayout StorageTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUStorageTextureBindingLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStorageTextureBindingLayout>>(JSObject, "storageTexture");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUStorageTextureBindingLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStorageTextureBindingLayout>>(JSObject, "storageTexture", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUExternalTextureBindingLayout ExternalTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUExternalTextureBindingLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUExternalTextureBindingLayout>>(JSObject, "externalTexture");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUExternalTextureBindingLayout, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUExternalTextureBindingLayout>>(JSObject, "externalTexture", value);
    }
}

#nullable disable