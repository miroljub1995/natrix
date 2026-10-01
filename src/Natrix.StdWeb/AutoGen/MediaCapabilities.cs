// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaCapabilities: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaCapabilities>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilities(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaCapabilities global::Natrix.JSCore.IJSObjectProxy<MediaCapabilities>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MediaCapabilities>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MediaCapabilitiesDecodingInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaCapabilitiesDecodingInfo>> DecodingInfo(global::Natrix.StdWeb.MediaDecodingConfiguration configuration)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = configuration.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "decodingInfo", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MediaCapabilitiesDecodingInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaCapabilitiesDecodingInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MediaCapabilitiesDecodingInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaCapabilitiesDecodingInfo>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MediaCapabilitiesEncodingInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaCapabilitiesEncodingInfo>> EncodingInfo(global::Natrix.StdWeb.MediaEncodingConfiguration configuration)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = configuration.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "encodingInfo", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MediaCapabilitiesEncodingInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaCapabilitiesEncodingInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MediaCapabilitiesEncodingInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaCapabilitiesEncodingInfo>>>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable