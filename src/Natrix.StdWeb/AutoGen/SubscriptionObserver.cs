// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SubscriptionObserver: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SubscriptionObserver>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SubscriptionObserver(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SubscriptionObserver global::Natrix.JSCore.IJSObjectProxy<SubscriptionObserver>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SubscriptionObserver(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ObservableSubscriptionCallback Next
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ObservableSubscriptionCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ObservableSubscriptionCallback>>(JSObject, "next");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ObservableSubscriptionCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ObservableSubscriptionCallback>>(JSObject, "next", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ObservableSubscriptionCallback Error
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ObservableSubscriptionCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ObservableSubscriptionCallback>>(JSObject, "error");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ObservableSubscriptionCallback, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ObservableSubscriptionCallback>>(JSObject, "error", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VoidFunction Complete
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VoidFunction, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VoidFunction>>(JSObject, "complete");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VoidFunction, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VoidFunction>>(JSObject, "complete", value);
    }
}

#nullable disable