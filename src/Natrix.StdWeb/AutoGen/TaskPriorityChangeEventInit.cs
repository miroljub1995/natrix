// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TaskPriorityChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<TaskPriorityChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TaskPriorityChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TaskPriorityChangeEventInit global::Natrix.JSCore.IJSObjectProxy<TaskPriorityChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TaskPriorityChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.TaskPriority PreviousPriority
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.TaskPriority, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TaskPriority>>(JSObject, "previousPriority");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.TaskPriority, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TaskPriority>>(JSObject, "previousPriority", value);
    }
}

#nullable disable