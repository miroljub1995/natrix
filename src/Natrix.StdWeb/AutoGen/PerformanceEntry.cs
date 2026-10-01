// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceEntry: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PerformanceEntry>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceEntry(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceEntry global::Natrix.JSCore.IJSObjectProxy<PerformanceEntry>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformanceEntry>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Id
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "id");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EntryType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "entryType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double StartTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "startTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Duration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "duration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong NavigationId
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "navigationId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable