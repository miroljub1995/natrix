// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCPeerConnectionIceErrorEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<RTCPeerConnectionIceErrorEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCPeerConnectionIceErrorEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCPeerConnectionIceErrorEventInit global::Natrix.JSCore.IJSObjectProxy<RTCPeerConnectionIceErrorEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCPeerConnectionIceErrorEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Address
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "address");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "address", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? Port
    {
        get => global::Natrix.JSCore.Generics.NullableUInt16Accessor.Get(JSObject, "port");
        set => global::Natrix.JSCore.Generics.NullableUInt16Accessor.Set(JSObject, "port", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Url
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "url");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "url", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required ushort ErrorCode
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "errorCode");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "errorCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ErrorText
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "errorText");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "errorText", value);
    }
}

#nullable disable