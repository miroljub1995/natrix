// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUTexelCopyTextureInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUTexelCopyTextureInfo>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTexelCopyTextureInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUTexelCopyTextureInfo global::Natrix.JSCore.IJSObjectProxy<GPUTexelCopyTextureInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTexelCopyTextureInfo(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUTexture Texture
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>.Get(JSObject, "texture");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>.Set(JSObject, "texture", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MipLevel
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "mipLevel");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "mipLevel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.StdWeb.GPUOrigin3DDict, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUOrigin3DDict>> Origin
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.StdWeb.GPUOrigin3DDict, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUOrigin3DDict>>>.Get(JSObject, "origin");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.StdWeb.GPUOrigin3DDict, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUOrigin3DDict>>>.Set(JSObject, "origin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureAspect Aspect
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureAspect>.Get(JSObject, "aspect");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureAspect>.Set(JSObject, "aspect", value);
    }
}

#nullable disable