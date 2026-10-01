// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NavigationCurrentEntryChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<NavigationCurrentEntryChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationCurrentEntryChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NavigationCurrentEntryChangeEventInit global::Natrix.JSCore.IJSObjectProxy<NavigationCurrentEntryChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationCurrentEntryChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationType? NavigationType
    {
        get => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.NavigationType>.Get(JSObject, "navigationType");
        set => global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.NavigationType>.Set(JSObject, "navigationType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.NavigationHistoryEntry From
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry>.Get(JSObject, "from");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry>.Set(JSObject, "from", value);
    }
}

#nullable disable