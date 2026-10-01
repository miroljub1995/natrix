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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "startTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Duration
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "duration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EntryType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "entryType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScriptInvokerType InvokerType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ScriptInvokerType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScriptInvokerType>>(JSObject, "invokerType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Invoker
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "invoker");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ExecutionStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "executionStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SourceURL
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "sourceURL");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SourceFunctionName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "sourceFunctionName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long SourceCharPosition
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<long, global::Natrix.JSCore.Generics.Int64Accessor>(JSObject, "sourceCharPosition");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PauseDuration
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "pauseDuration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ForcedStyleAndLayoutDuration
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "forcedStyleAndLayoutDuration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Window? Window
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Window?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Window>>(JSObject, "window");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScriptWindowAttribution WindowAttribution
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ScriptWindowAttribution, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScriptWindowAttribution>>(JSObject, "windowAttribution");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.JSCore.Generics.JSObjectAccessor>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable