// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PushSubscriptionChangeEventInit: global::Natrix.StdWeb.ExtendableEventInit, global::Natrix.JSCore.IJSObjectProxy<PushSubscriptionChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushSubscriptionChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PushSubscriptionChangeEventInit global::Natrix.JSCore.IJSObjectProxy<PushSubscriptionChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushSubscriptionChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PushSubscription NewSubscription
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PushSubscription>.Get(JSObject, "newSubscription");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PushSubscription>.Set(JSObject, "newSubscription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PushSubscription OldSubscription
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PushSubscription>.Get(JSObject, "oldSubscription");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PushSubscription>.Set(JSObject, "oldSubscription", value);
    }
}

#nullable disable