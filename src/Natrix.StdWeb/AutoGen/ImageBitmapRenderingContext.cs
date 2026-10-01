// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageBitmapRenderingContext: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImageBitmapRenderingContext>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageBitmapRenderingContext(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImageBitmapRenderingContext global::Natrix.JSCore.IJSObjectProxy<ImageBitmapRenderingContext>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ImageBitmapRenderingContext>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCanvasElement, global::Natrix.StdWeb.OffscreenCanvas, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCanvasElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvas>> Canvas
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCanvasElement, global::Natrix.StdWeb.OffscreenCanvas, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCanvasElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvas>>>.Get(JSObject, "canvas");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void TransferFromImageBitmap(global::Natrix.StdWeb.ImageBitmap? bitmap)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_3;
        if (bitmap is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            global::Natrix.StdWeb.ImageBitmap ___notNullable_4 = (global::Natrix.StdWeb.ImageBitmap)bitmap;
            ___marshalledValue_3 = ___notNullable_4.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "transferFromImageBitmap", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable