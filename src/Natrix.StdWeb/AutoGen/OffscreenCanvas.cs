// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OffscreenCanvas: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<OffscreenCanvas>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OffscreenCanvas(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OffscreenCanvas global::Natrix.JSCore.IJSObjectProxy<OffscreenCanvas>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<OffscreenCanvas>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.OffscreenCanvas New(ulong width, ulong height)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        double ___marshalledValue_4;
        ___marshalledValue_4 = Convert.ToDouble(width);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(height);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "OffscreenCanvas", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.OffscreenCanvas(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "width");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Height
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "height");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageBitmapRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGLRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGL2RenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCanvasContext>>? GetContext(global::Natrix.StdWeb.OffscreenRenderingContextId contextId)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = contextId.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getContext", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageBitmapRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGLRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGL2RenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCanvasContext>>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageBitmapRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGLRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGL2RenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCanvasContext>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageBitmapRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGLRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGL2RenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCanvasContext>>? GetContext(global::Natrix.StdWeb.OffscreenRenderingContextId contextId, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = contextId.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_4;
        if (options is null)
        {
            ___propObject_4 = null;
        }
        else
        {
            ___propObject_4 = options.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 1, ___propObject_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getContext", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageBitmapRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGLRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGL2RenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCanvasContext>>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageBitmapRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGLRenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebGL2RenderingContext>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCanvasContext>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ImageBitmap TransferToImageBitmap()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "transferToImageBitmap", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ImageBitmap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageBitmap>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>> ConvertToBlob()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "convertToBlob", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>> ConvertToBlob(global::Natrix.StdWeb.ImageEncodeOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "convertToBlob", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Oncontextlost
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "oncontextlost");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "oncontextlost", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Oncontextrestored
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "oncontextrestored");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "oncontextrestored", value);
    }
}

#nullable disable