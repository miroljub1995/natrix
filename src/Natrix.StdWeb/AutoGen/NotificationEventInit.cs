// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NotificationEventInit: global::Natrix.StdWeb.ExtendableEventInit, global::Natrix.JSCore.IJSObjectProxy<NotificationEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NotificationEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NotificationEventInit global::Natrix.JSCore.IJSObjectProxy<NotificationEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NotificationEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.Notification Notification
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Notification>.Get(JSObject, "notification");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Notification>.Set(JSObject, "notification", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Action
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "action");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "action", value);
    }
}

#nullable disable