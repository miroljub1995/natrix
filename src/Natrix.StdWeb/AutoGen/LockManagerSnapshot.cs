// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LockManagerSnapshot: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LockManagerSnapshot>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LockManagerSnapshot(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LockManagerSnapshot global::Natrix.JSCore.IJSObjectProxy<LockManagerSnapshot>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LockManagerSnapshot(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LockInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LockInfo>> Held
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LockInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LockInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LockInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LockInfo>>>>(JSObject, "held");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LockInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LockInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LockInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LockInfo>>>>(JSObject, "held", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LockInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LockInfo>> Pending
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LockInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LockInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LockInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LockInfo>>>>(JSObject, "pending");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LockInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LockInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LockInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LockInfo>>>>(JSObject, "pending", value);
    }
}

#nullable disable