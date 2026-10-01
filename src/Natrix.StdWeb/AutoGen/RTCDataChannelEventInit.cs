// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCDataChannelEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<RTCDataChannelEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCDataChannelEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCDataChannelEventInit global::Natrix.JSCore.IJSObjectProxy<RTCDataChannelEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCDataChannelEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCDataChannel Channel
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCDataChannel>.Get(JSObject, "channel");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCDataChannel>.Set(JSObject, "channel", value);
    }
}

#nullable disable