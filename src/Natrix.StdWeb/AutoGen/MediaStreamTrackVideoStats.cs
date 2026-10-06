// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaStreamTrackVideoStats: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaStreamTrackVideoStats>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaStreamTrackVideoStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaStreamTrackVideoStats global::Natrix.JSCore.IJSObjectProxy<MediaStreamTrackVideoStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MediaStreamTrackVideoStats>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DeliveredFrames
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "deliveredFrames");
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

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable