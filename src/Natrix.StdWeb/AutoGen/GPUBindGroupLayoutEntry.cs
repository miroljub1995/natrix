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
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "binding");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "binding", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Visibility
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "visibility");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "visibility", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUBufferBindingLayout Buffer
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBufferBindingLayout>.Get(JSObject, "buffer");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBufferBindingLayout>.Set(JSObject, "buffer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUSamplerBindingLayout Sampler
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUSamplerBindingLayout>.Get(JSObject, "sampler");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUSamplerBindingLayout>.Set(JSObject, "sampler", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureBindingLayout Texture
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureBindingLayout>.Get(JSObject, "texture");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureBindingLayout>.Set(JSObject, "texture", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStorageTextureBindingLayout StorageTexture
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStorageTextureBindingLayout>.Get(JSObject, "storageTexture");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStorageTextureBindingLayout>.Set(JSObject, "storageTexture", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUExternalTextureBindingLayout ExternalTexture
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUExternalTextureBindingLayout>.Get(JSObject, "externalTexture");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUExternalTextureBindingLayout>.Set(JSObject, "externalTexture", value);
    }
}

#nullable disable