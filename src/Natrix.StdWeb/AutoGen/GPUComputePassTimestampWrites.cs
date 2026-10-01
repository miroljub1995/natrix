// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUComputePassTimestampWrites: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUComputePassTimestampWrites>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUComputePassTimestampWrites(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUComputePassTimestampWrites global::Natrix.JSCore.IJSObjectProxy<GPUComputePassTimestampWrites>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUComputePassTimestampWrites(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUQuerySet QuerySet
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUQuerySet>.Get(JSObject, "querySet");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUQuerySet>.Set(JSObject, "querySet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint BeginningOfPassWriteIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "beginningOfPassWriteIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "beginningOfPassWriteIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint EndOfPassWriteIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "endOfPassWriteIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "endOfPassWriteIndex", value);
    }
}

#nullable disable