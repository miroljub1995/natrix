// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageBitmap: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImageBitmap>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageBitmap(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImageBitmap global::Natrix.JSCore.IJSObjectProxy<ImageBitmap>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ImageBitmap>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Width
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "width");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Height
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "height");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Close()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "close", JSObject);
    }
}

#nullable disable