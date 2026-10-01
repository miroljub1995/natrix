// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NavigationResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<NavigationResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NavigationResult global::Natrix.JSCore.IJSObjectProxy<NavigationResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.NavigationHistoryEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry>> Committed
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.NavigationHistoryEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry>>>.Get(JSObject, "committed");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.NavigationHistoryEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry>>>.Set(JSObject, "committed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.NavigationHistoryEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry>> Finished
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.NavigationHistoryEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry>>>.Get(JSObject, "finished");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.NavigationHistoryEntry, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry>>>.Set(JSObject, "finished", value);
    }
}

#nullable disable