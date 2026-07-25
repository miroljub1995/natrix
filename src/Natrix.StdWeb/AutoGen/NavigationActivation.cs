// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NavigationActivation: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationActivation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationHistoryEntry? From
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationHistoryEntry?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "from");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationHistoryEntry Entry
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationHistoryEntry, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "entry");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationType NavigationType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "navigationType");
    }
}

#nullable disable