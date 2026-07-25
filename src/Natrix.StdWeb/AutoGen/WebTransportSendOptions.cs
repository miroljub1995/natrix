// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportSendOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportSendOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportSendOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebTransportSendGroup? SendGroup
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebTransportSendGroup?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "sendGroup");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.WebTransportSendGroup?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "sendGroup", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long SendOrder
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<long, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sendOrder");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<long, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sendOrder", value);
    }
}

#nullable disable