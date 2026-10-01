// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ObservableInspector: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ObservableInspector>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ObservableInspector(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ObservableInspector global::Natrix.JSCore.IJSObjectProxy<ObservableInspector>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ObservableInspector(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ObservableSubscriptionCallback Next
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ObservableSubscriptionCallback>.Get(JSObject, "next");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ObservableSubscriptionCallback>.Set(JSObject, "next", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ObservableSubscriptionCallback Error
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ObservableSubscriptionCallback>.Get(JSObject, "error");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ObservableSubscriptionCallback>.Set(JSObject, "error", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VoidFunction Complete
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VoidFunction>.Get(JSObject, "complete");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VoidFunction>.Set(JSObject, "complete", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VoidFunction Subscribe
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VoidFunction>.Get(JSObject, "subscribe");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VoidFunction>.Set(JSObject, "subscribe", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ObservableInspectorAbortHandler Abort
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ObservableInspectorAbortHandler>.Get(JSObject, "abort");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ObservableInspectorAbortHandler>.Set(JSObject, "abort", value);
    }
}

#nullable disable