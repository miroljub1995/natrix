// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportErrorOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebTransportErrorOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportErrorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportErrorOptions global::Natrix.JSCore.IJSObjectProxy<WebTransportErrorOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportErrorOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebTransportErrorSource Source
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebTransportErrorSource, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WebTransportErrorSource>>(JSObject, "source");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.WebTransportErrorSource, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WebTransportErrorSource>>(JSObject, "source", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? StreamErrorCode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.JSCore.Generics.NullableUInt32Accessor>(JSObject, "streamErrorCode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint?, global::Natrix.JSCore.Generics.NullableUInt32Accessor>(JSObject, "streamErrorCode", value);
    }
}

#nullable disable