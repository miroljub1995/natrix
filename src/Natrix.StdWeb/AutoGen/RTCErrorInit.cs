// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCErrorInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCErrorInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCErrorInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCErrorInit global::Natrix.JSCore.IJSObjectProxy<RTCErrorInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCErrorInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int HttpRequestStatusCode
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "httpRequestStatusCode");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "httpRequestStatusCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCErrorDetailType ErrorDetail
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCErrorDetailType>.Get(JSObject, "errorDetail");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCErrorDetailType>.Set(JSObject, "errorDetail", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int SdpLineNumber
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "sdpLineNumber");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "sdpLineNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int SctpCauseCode
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "sctpCauseCode");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "sctpCauseCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ReceivedAlert
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "receivedAlert");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "receivedAlert", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SentAlert
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "sentAlert");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "sentAlert", value);
    }
}

#nullable disable