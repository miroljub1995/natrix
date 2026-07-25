// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIceCandidateStats: global::Natrix.StdWeb.RTCStats
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceCandidateStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceCandidateStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string TransportId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transportId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transportId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Address
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "address");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "address", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Port
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "port");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "port", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Protocol
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "protocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCIceCandidateType CandidateType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceCandidateType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "candidateType");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCIceCandidateType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "candidateType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Priority
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "priority");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "priority", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Url
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "url");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "url", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceServerTransportProtocol RelayProtocol
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceServerTransportProtocol, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "relayProtocol");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCIceServerTransportProtocol, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "relayProtocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Foundation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "foundation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "foundation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RelatedAddress
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "relatedAddress");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "relatedAddress", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int RelatedPort
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "relatedPort");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "relatedPort", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UsernameFragment
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "usernameFragment");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "usernameFragment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceTcpCandidateType TcpType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceTcpCandidateType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "tcpType");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCIceTcpCandidateType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "tcpType", value);
    }
}

#nullable disable