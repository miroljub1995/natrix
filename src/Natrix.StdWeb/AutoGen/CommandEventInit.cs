// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CommandEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<CommandEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CommandEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CommandEventInit global::Natrix.JSCore.IJSObjectProxy<CommandEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CommandEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? Source
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "source");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Set(JSObject, "source", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Command
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "command");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "command", value);
    }
}

#nullable disable