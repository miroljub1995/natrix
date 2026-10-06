// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class InstallResultEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<InstallResultEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InstallResultEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static InstallResultEventInit global::Natrix.JSCore.IJSObjectProxy<InstallResultEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InstallResultEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.InstallResult Result
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.InstallResult>.Get(JSObject, "result");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.InstallResult>.Set(JSObject, "result", value);
    }
}

#nullable disable