// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TaskAttributionTiming: global::Natrix.StdWeb.PerformanceEntry, global::Natrix.JSCore.IJSObjectProxy<TaskAttributionTiming>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TaskAttributionTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TaskAttributionTiming global::Natrix.JSCore.IJSObjectProxy<TaskAttributionTiming>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TaskAttributionTiming>(obj);

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
    public string ContainerType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "containerType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContainerSrc
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "containerSrc");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContainerId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "containerId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContainerName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "containerName");
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