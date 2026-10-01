// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TextDetector: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TextDetector>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextDetector(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TextDetector global::Natrix.JSCore.IJSObjectProxy<TextDetector>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TextDetector>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.TextDetector New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextDetector");
        return new global::Natrix.StdWeb.TextDetector(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Availability, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.Availability>> Availability(global::Natrix.StdWeb.TextDetectorOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextDetector"), "availability", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextDetector"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Availability, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.Availability>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.TextDetector, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextDetector>> Create()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextDetector"), "create", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextDetector"), ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.TextDetector, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextDetector>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.TextDetector, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextDetector>> Create(global::Natrix.StdWeb.TextDetectorCreateOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextDetector"), "create", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextDetector"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.TextDetector, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextDetector>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DetectedText, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DetectedText>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DetectedText, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DetectedText>>>> Detect(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLImageElement, global::Natrix.StdWeb.SVGImageElement, global::Natrix.StdWeb.HTMLVideoElement, global::Natrix.StdWeb.HTMLCanvasElement, global::Natrix.StdWeb.ImageBitmap, global::Natrix.StdWeb.OffscreenCanvas, global::Natrix.StdWeb.VideoFrame, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.ImageData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLImageElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGImageElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLVideoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCanvasElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageBitmap>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvas>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoFrame>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageData>> image)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = image.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "detect", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DetectedText, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DetectedText>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DetectedText, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DetectedText>>>>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable