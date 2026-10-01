// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ProofreaderCreateOptions: global::Natrix.StdWeb.ProofreaderCreateCoreOptions, global::Natrix.JSCore.IJSObjectProxy<ProofreaderCreateOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProofreaderCreateOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ProofreaderCreateOptions global::Natrix.JSCore.IJSObjectProxy<ProofreaderCreateOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProofreaderCreateOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AbortSignal Signal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Get(JSObject, "signal");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Set(JSObject, "signal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CreateMonitorCallback Monitor
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CreateMonitorCallback>.Get(JSObject, "monitor");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CreateMonitorCallback>.Set(JSObject, "monitor", value);
    }
}

#nullable disable