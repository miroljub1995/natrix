// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TaskControllerInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TaskControllerInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TaskControllerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TaskControllerInit global::Natrix.JSCore.IJSObjectProxy<TaskControllerInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TaskControllerInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TaskPriority Priority
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TaskPriority>.Get(JSObject, "priority");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TaskPriority>.Set(JSObject, "priority", value);
    }
}

#nullable disable