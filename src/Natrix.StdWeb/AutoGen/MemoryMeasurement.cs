// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MemoryMeasurement: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MemoryMeasurement>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MemoryMeasurement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MemoryMeasurement global::Natrix.JSCore.IJSObjectProxy<MemoryMeasurement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MemoryMeasurement(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Bytes
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytes");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MemoryBreakdownEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MemoryBreakdownEntry>> Breakdown
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MemoryBreakdownEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MemoryBreakdownEntry>>>.Get(JSObject, "breakdown");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MemoryBreakdownEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MemoryBreakdownEntry>>>.Set(JSObject, "breakdown", value);
    }
}

#nullable disable