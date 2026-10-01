// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportSendStreamOptions: global::Natrix.StdWeb.WebTransportSendOptions, global::Natrix.JSCore.IJSObjectProxy<WebTransportSendStreamOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportSendStreamOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportSendStreamOptions global::Natrix.JSCore.IJSObjectProxy<WebTransportSendStreamOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportSendStreamOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool WaitUntilAvailable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "waitUntilAvailable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "waitUntilAvailable", value);
    }
}

#nullable disable