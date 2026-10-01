// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WorkerOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WorkerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WorkerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WorkerOptions global::Natrix.JSCore.IJSObjectProxy<WorkerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WorkerOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WorkerType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WorkerType>.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WorkerType>.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RequestCredentials Credentials
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RequestCredentials>.Get(JSObject, "credentials");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RequestCredentials>.Set(JSObject, "credentials", value);
    }
}

#nullable disable