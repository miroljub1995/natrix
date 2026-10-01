// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCError: global::Natrix.StdWeb.DOMException, global::Natrix.JSCore.IJSObjectProxy<RTCError>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCError(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCError global::Natrix.JSCore.IJSObjectProxy<RTCError>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RTCError>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? HttpRequestStatusCode
    {
        get => global::Natrix.JSCore.Generics.NullableInt32Accessor.Get(JSObject, "httpRequestStatusCode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.RTCError New(global::Natrix.StdWeb.RTCErrorInit init)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "RTCError", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.RTCError(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.RTCError New(global::Natrix.StdWeb.RTCErrorInit init, string message)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        string ___marshalledValue_5;
        ___marshalledValue_5 = message;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "RTCError", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.RTCError(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCErrorDetailType ErrorDetail
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCErrorDetailType>.Get(JSObject, "errorDetail");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? SdpLineNumber
    {
        get => global::Natrix.JSCore.Generics.NullableInt32Accessor.Get(JSObject, "sdpLineNumber");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int? SctpCauseCode
    {
        get => global::Natrix.JSCore.Generics.NullableInt32Accessor.Get(JSObject, "sctpCauseCode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? ReceivedAlert
    {
        get => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Get(JSObject, "receivedAlert");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint? SentAlert
    {
        get => global::Natrix.JSCore.Generics.NullableUInt32Accessor.Get(JSObject, "sentAlert");
    }
}

#nullable disable