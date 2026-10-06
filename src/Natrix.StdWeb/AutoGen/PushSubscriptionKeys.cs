// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PushSubscriptionKeys: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PushSubscriptionKeys>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushSubscriptionKeys(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PushSubscriptionKeys global::Natrix.JSCore.IJSObjectProxy<PushSubscriptionKeys>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PushSubscriptionKeys(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string P256dh
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "p256dh");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "p256dh", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Auth
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "auth");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "auth", value);
    }
}

#nullable disable