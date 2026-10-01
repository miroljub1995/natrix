// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUColorTargetState: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUColorTargetState>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUColorTargetState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUColorTargetState global::Natrix.JSCore.IJSObjectProxy<GPUColorTargetState>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUColorTargetState(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUTextureFormat Format
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Get(JSObject, "format");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Set(JSObject, "format", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUBlendState Blend
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBlendState>.Get(JSObject, "blend");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBlendState>.Set(JSObject, "blend", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint WriteMask
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "writeMask");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "writeMask", value);
    }
}

#nullable disable