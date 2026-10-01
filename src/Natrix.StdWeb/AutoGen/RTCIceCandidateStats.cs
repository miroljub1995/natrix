// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIceCandidateStats: global::Natrix.StdWeb.RTCStats, global::Natrix.JSCore.IJSObjectProxy<RTCIceCandidateStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceCandidateStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCIceCandidateStats global::Natrix.JSCore.IJSObjectProxy<RTCIceCandidateStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceCandidateStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string TransportId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "transportId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "transportId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Address
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "address");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "address", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Port
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "port");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "port", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Protocol
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "protocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCIceCandidateType CandidateType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceCandidateType>.Get(JSObject, "candidateType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceCandidateType>.Set(JSObject, "candidateType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Priority
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "priority");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "priority", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Url
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "url");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "url", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceServerTransportProtocol RelayProtocol
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceServerTransportProtocol>.Get(JSObject, "relayProtocol");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceServerTransportProtocol>.Set(JSObject, "relayProtocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Foundation
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "foundation");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "foundation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RelatedAddress
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "relatedAddress");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "relatedAddress", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int RelatedPort
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "relatedPort");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "relatedPort", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UsernameFragment
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "usernameFragment");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "usernameFragment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceTcpCandidateType TcpType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceTcpCandidateType>.Get(JSObject, "tcpType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceTcpCandidateType>.Set(JSObject, "tcpType", value);
    }
}

#nullable disable