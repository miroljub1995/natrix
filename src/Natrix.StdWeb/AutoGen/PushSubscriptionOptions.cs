// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PushSubscriptionOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PushSubscriptionOptions>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushSubscriptionOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PushSubscriptionOptions global::Natrix.JSCore.IJSObjectProxy<PushSubscriptionOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PushSubscriptionOptions>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool UserVisibleOnly
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "userVisibleOnly");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer? ApplicationServerKey
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.ArrayBuffer?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.ArrayBuffer>>(JSObject, "applicationServerKey");
    }
}

#nullable disable