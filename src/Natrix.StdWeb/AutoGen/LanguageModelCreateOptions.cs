// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelCreateOptions: global::Natrix.StdWeb.LanguageModelCreateCoreOptions, global::Natrix.JSCore.IJSObjectProxy<LanguageModelCreateOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelCreateOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LanguageModelCreateOptions global::Natrix.JSCore.IJSObjectProxy<LanguageModelCreateOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelCreateOptions(): base()
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
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelMessage>> InitialPrompts
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelMessage>>>.Get(JSObject, "initialPrompts");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelMessage>>>.Set(JSObject, "initialPrompts", value);
    }
}

#nullable disable