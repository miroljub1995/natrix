// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaError: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaError>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaError(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaError global::Natrix.JSCore.IJSObjectProxy<MediaError>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MediaError>(obj);

    public const ushort MEDIA_ERR_ABORTED = 1;

    public const ushort MEDIA_ERR_NETWORK = 2;

    public const ushort MEDIA_ERR_DECODE = 3;

    public const ushort MEDIA_ERR_SRC_NOT_SUPPORTED = 4;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Code
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "code");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Message
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "message");
    }
}

#nullable disable