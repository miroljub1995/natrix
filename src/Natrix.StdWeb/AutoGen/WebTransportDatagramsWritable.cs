// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportDatagramsWritable: global::Natrix.StdWeb.WritableStream
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportDatagramsWritable(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
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