// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportSendOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebTransportSendOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportSendOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportSendOptions global::Natrix.JSCore.IJSObjectProxy<WebTransportSendOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportSendOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebTransportSendGroup? SendGroup
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WebTransportSendGroup>.Get(JSObject, "sendGroup");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WebTransportSendGroup>.Set(JSObject, "sendGroup", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long SendOrder
    {
        get => global::Natrix.JSCore.Generics.Int64Accessor.Get(JSObject, "sendOrder");
        set => global::Natrix.JSCore.Generics.Int64Accessor.Set(JSObject, "sendOrder", value);
    }
}

#nullable disable