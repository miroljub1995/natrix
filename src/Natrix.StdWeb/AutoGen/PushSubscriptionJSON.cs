// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PushSubscriptionJSON: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PushSubscriptionJSON>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushSubscriptionJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PushSubscriptionJSON global::Natrix.JSCore.IJSObjectProxy<PushSubscriptionJSON>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushSubscriptionJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Endpoint
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "endpoint");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "endpoint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong? ExpirationTime
    {
        get => global::Natrix.JSCore.Generics.NullableUInt64Accessor.Get(JSObject, "expirationTime");
        set => global::Natrix.JSCore.Generics.NullableUInt64Accessor.Set(JSObject, "expirationTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PushSubscriptionKeys Keys
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PushSubscriptionKeys>.Get(JSObject, "keys");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PushSubscriptionKeys>.Set(JSObject, "keys", value);
    }
}

#nullable disable