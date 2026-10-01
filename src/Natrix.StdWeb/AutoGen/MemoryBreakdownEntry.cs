// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MemoryBreakdownEntry: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MemoryBreakdownEntry>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MemoryBreakdownEntry(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MemoryBreakdownEntry global::Natrix.JSCore.IJSObjectProxy<MemoryBreakdownEntry>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MemoryBreakdownEntry(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Bytes
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytes");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MemoryAttribution, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MemoryAttribution>> Attribution
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MemoryAttribution, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MemoryAttribution>>>.Get(JSObject, "attribution");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MemoryAttribution, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MemoryAttribution>>>.Set(JSObject, "attribution", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Types
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "types");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "types", value);
    }
}

#nullable disable