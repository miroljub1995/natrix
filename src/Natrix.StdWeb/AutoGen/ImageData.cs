// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageData: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImageData>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageData(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImageData global::Natrix.JSCore.IJSObjectProxy<ImageData>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ImageData>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ImageData New(uint sw, uint sh)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        double ___marshalledValue_4;
        ___marshalledValue_4 = Convert.ToDouble(sw);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(sh);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ImageData", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ImageData(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ImageData New(uint sw, uint sh, global::Natrix.StdWeb.ImageDataSettings settings)
    {
        int ___argsArrayLength_3 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        double ___marshalledValue_4;
        ___marshalledValue_4 = Convert.ToDouble(sw);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(sh);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_6;
        ___marshalledValue_6 = settings.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 2, ___marshalledValue_6);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ImageData", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ImageData(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ImageData New(global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>> data, uint sw)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = data.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(sw);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ImageData", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ImageData(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ImageData New(global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>> data, uint sw, uint sh)
    {
        int ___argsArrayLength_3 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = data.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(sw);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        // Argument 3
        double ___marshalledValue_6;
        ___marshalledValue_6 = Convert.ToDouble(sh);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 2, ___marshalledValue_6);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ImageData", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ImageData(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ImageData New(global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>> data, uint sw, uint sh, global::Natrix.StdWeb.ImageDataSettings settings)
    {
        int ___argsArrayLength_3 = 4;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = data.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(sw);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        // Argument 3
        double ___marshalledValue_6;
        ___marshalledValue_6 = Convert.ToDouble(sh);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 2, ___marshalledValue_6);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_7;
        ___marshalledValue_7 = settings.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 3, ___marshalledValue_7);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ImageData", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ImageData(___res_2);
    }

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
    public global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>> Data
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>>>.Get(JSObject, "data");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ImageDataPixelFormat PixelFormat
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ImageDataPixelFormat>.Get(JSObject, "pixelFormat");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PredefinedColorSpace ColorSpace
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PredefinedColorSpace>.Get(JSObject, "colorSpace");
    }
}

#nullable disable