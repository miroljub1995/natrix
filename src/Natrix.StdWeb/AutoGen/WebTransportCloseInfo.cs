// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportCloseInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebTransportCloseInfo>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportCloseInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportCloseInfo global::Natrix.JSCore.IJSObjectProxy<WebTransportCloseInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportCloseInfo(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CloseCode
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "closeCode");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "closeCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Reason
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "reason");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "reason", value);
    }
}

#nullable disable