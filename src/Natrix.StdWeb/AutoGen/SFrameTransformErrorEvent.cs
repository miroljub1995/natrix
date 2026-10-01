// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SFrameTransformErrorEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<SFrameTransformErrorEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SFrameTransformErrorEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SFrameTransformErrorEvent global::Natrix.JSCore.IJSObjectProxy<SFrameTransformErrorEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SFrameTransformErrorEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SFrameTransformErrorEvent New(string type, global::Natrix.StdWeb.SFrameTransformErrorEventInit eventInitDict)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = eventInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SFrameTransformErrorEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.SFrameTransformErrorEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SFrameTransformErrorEventType ErrorType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SFrameTransformErrorEventType>.Get(JSObject, "errorType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.JSCore.Generics.UInt64Accessor, global::Natrix.JSCore.Generics.BigIntegerAccessor>? KeyID
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.JSCore.Generics.UInt64Accessor, global::Natrix.JSCore.Generics.BigIntegerAccessor>>.Get(JSObject, "keyID");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCEncodedVideoFrame, global::Natrix.StdWeb.RTCEncodedAudioFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedVideoFrame>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedAudioFrame>> Frame
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCEncodedVideoFrame, global::Natrix.StdWeb.RTCEncodedAudioFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedVideoFrame>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedAudioFrame>>>.Get(JSObject, "frame");
    }
}

#nullable disable