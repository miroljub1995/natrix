// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBufferBinding: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUBufferBinding>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBufferBinding(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUBufferBinding global::Natrix.JSCore.IJSObjectProxy<GPUBufferBinding>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBufferBinding(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUBuffer Buffer
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBuffer>.Get(JSObject, "buffer");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUBuffer>.Set(JSObject, "buffer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Offset
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "offset");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "offset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Size
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "size");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "size", value);
    }
}

#nullable disable