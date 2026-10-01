// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SummarizerCreateOptions: global::Natrix.StdWeb.SummarizerCreateCoreOptions, global::Natrix.JSCore.IJSObjectProxy<SummarizerCreateOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SummarizerCreateOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SummarizerCreateOptions global::Natrix.JSCore.IJSObjectProxy<SummarizerCreateOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SummarizerCreateOptions(): base()
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

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SharedContext
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sharedContext");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "sharedContext", value);
    }
}

#nullable disable