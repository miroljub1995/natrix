// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaError: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaError(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    public const ushort MEDIA_ERR_ABORTED = 1;

    public const ushort MEDIA_ERR_NETWORK = 2;

    public const ushort MEDIA_ERR_DECODE = 3;

    public const ushort MEDIA_ERR_SRC_NOT_SUPPORTED = 4;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Code
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "code");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Message
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "message");
    }
}

#nullable disable