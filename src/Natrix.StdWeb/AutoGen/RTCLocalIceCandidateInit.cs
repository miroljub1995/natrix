// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCLocalIceCandidateInit: global::Natrix.StdWeb.RTCIceCandidateInit, global::Natrix.JSCore.IJSObjectProxy<RTCLocalIceCandidateInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCLocalIceCandidateInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCLocalIceCandidateInit global::Natrix.JSCore.IJSObjectProxy<RTCLocalIceCandidateInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCLocalIceCandidateInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceServerTransportProtocol? RelayProtocol
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceServerTransportProtocol?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.RTCIceServerTransportProtocol>>(JSObject, "relayProtocol");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCIceServerTransportProtocol?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.RTCIceServerTransportProtocol>>(JSObject, "relayProtocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Url
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "url");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "url", value);
    }
}

#nullable disable