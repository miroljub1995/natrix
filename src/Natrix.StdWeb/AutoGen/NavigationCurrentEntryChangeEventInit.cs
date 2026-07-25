// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NavigationCurrentEntryChangeEventInit: global::Natrix.StdWeb.EventInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationCurrentEntryChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationCurrentEntryChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationType? NavigationType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationType?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "navigationType");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationType?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "navigationType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.NavigationHistoryEntry From
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationHistoryEntry, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "from");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationHistoryEntry, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "from", value);
    }
}

#nullable disable