// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaStreamTrackProcessor: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaStreamTrackProcessor>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaStreamTrackProcessor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaStreamTrackProcessor global::Natrix.JSCore.IJSObjectProxy<MediaStreamTrackProcessor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MediaStreamTrackProcessor>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.MediaStreamTrackProcessor New(global::Natrix.StdWeb.MediaStreamTrackProcessorInit init)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "MediaStreamTrackProcessor", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.MediaStreamTrackProcessor(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ReadableStream Readable
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStream>.Get(JSObject, "readable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DiscardedFrames
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "discardedFrames");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong TotalFrames
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "totalFrames");
    }
}

#nullable disable