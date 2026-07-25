// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PushSubscriptionChangeEventInit: global::Natrix.StdWeb.ExtendableEventInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushSubscriptionChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushSubscriptionChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PushSubscription NewSubscription
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PushSubscription, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "newSubscription");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PushSubscription, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "newSubscription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PushSubscription OldSubscription
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PushSubscription, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "oldSubscription");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PushSubscription, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "oldSubscription", value);
    }
}

#nullable disable