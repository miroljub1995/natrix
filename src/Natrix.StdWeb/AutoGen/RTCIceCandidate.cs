// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIceCandidate: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCIceCandidate>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceCandidate(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCIceCandidate global::Natrix.JSCore.IJSObjectProxy<RTCIceCandidate>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RTCIceCandidate>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.RTCIceCandidate New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "RTCIceCandidate");
        return new global::Natrix.StdWeb.RTCIceCandidate(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.RTCIceCandidate New(global::Natrix.StdWeb.RTCLocalIceCandidateInit candidateInitDict)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = candidateInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "RTCIceCandidate", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.RTCIceCandidate(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Candidate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "candidate");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SdpMid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "sdpMid");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? SdpMLineIndex
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort?, global::Natrix.JSCore.Generics.NullableUInt16Accessor>(JSObject, "sdpMLineIndex");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Foundation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "foundation");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceComponent? Component
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceComponent?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.RTCIceComponent>>(JSObject, "component");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? Priority
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint?, global::Natrix.JSCore.Generics.NullableUInt32Accessor>(JSObject, "priority");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Address
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "address");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceProtocol? Protocol
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceProtocol?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.RTCIceProtocol>>(JSObject, "protocol");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? Port
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort?, global::Natrix.JSCore.Generics.NullableUInt16Accessor>(JSObject, "port");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceCandidateType? Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceCandidateType?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.RTCIceCandidateType>>(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceTcpCandidateType? TcpType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceTcpCandidateType?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.RTCIceTcpCandidateType>>(JSObject, "tcpType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? RelatedAddress
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "relatedAddress");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? RelatedPort
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort?, global::Natrix.JSCore.Generics.NullableUInt16Accessor>(JSObject, "relatedPort");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? UsernameFragment
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "usernameFragment");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceServerTransportProtocol? RelayProtocol
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceServerTransportProtocol?, global::Natrix.JSCore.Generics.NullableEnumAccessor<global::Natrix.StdWeb.RTCIceServerTransportProtocol>>(JSObject, "relayProtocol");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Url
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "url");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceCandidateInit ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceCandidateInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceCandidateInit>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable