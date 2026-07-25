// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUTexelCopyTextureInfo: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTexelCopyTextureInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTexelCopyTextureInfo(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUTexture Texture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "texture");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "texture", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MipLevel
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mipLevel");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mipLevel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GPUOrigin3DDict, global::Natrix.StdWeb.GenericMarshaller.Union> Origin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GPUOrigin3DDict, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "origin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GPUOrigin3DDict, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "origin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureAspect Aspect
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureAspect, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "aspect");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUTextureAspect, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "aspect", value);
    }
}

#nullable disable