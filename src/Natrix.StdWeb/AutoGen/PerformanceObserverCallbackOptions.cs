// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceObserverCallbackOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PerformanceObserverCallbackOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceObserverCallbackOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceObserverCallbackOptions global::Natrix.JSCore.IJSObjectProxy<PerformanceObserverCallbackOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceObserverCallbackOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DroppedEntriesCount
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "droppedEntriesCount");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "droppedEntriesCount", value);
    }
}

#nullable disable