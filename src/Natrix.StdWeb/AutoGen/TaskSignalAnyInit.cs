// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TaskSignalAnyInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TaskSignalAnyInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TaskSignalAnyInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TaskSignalAnyInit global::Natrix.JSCore.IJSObjectProxy<TaskSignalAnyInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TaskSignalAnyInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TaskPriority, global::Natrix.StdWeb.TaskSignal, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TaskPriority>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TaskSignal>> Priority
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TaskPriority, global::Natrix.StdWeb.TaskSignal, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TaskPriority>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TaskSignal>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TaskPriority, global::Natrix.StdWeb.TaskSignal, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TaskPriority>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TaskSignal>>>>(JSObject, "priority");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TaskPriority, global::Natrix.StdWeb.TaskSignal, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TaskPriority>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TaskSignal>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TaskPriority, global::Natrix.StdWeb.TaskSignal, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TaskPriority>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TaskSignal>>>>(JSObject, "priority", value);
    }
}

#nullable disable