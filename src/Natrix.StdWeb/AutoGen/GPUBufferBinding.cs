// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBufferBinding: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBufferBinding(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBufferBinding(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUBuffer Buffer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUBuffer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "buffer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUBuffer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "buffer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Offset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "offset");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "offset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Size
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "size");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "size", value);
    }
}

#nullable disable