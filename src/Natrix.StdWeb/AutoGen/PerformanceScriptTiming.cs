// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceScriptTiming: global::Natrix.StdWeb.PerformanceEntry, global::Natrix.JSCore.IJSObjectProxy<PerformanceScriptTiming>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceScriptTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceScriptTiming global::Natrix.JSCore.IJSObjectProxy<PerformanceScriptTiming>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformanceScriptTiming>(obj);

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
    public global::Natrix.StdWeb.ScriptInvokerType InvokerType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScriptInvokerType>.Get(JSObject, "invokerType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Invoker
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "invoker");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ExecutionStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "executionStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SourceURL
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sourceURL");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SourceFunctionName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sourceFunctionName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long SourceCharPosition
    {
        get => global::Natrix.JSCore.Generics.Int64Accessor.Get(JSObject, "sourceCharPosition");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PauseDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "pauseDuration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ForcedStyleAndLayoutDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "forcedStyleAndLayoutDuration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Window? Window
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Window>.Get(JSObject, "window");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScriptWindowAttribution WindowAttribution
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScriptWindowAttribution>.Get(JSObject, "windowAttribution");
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