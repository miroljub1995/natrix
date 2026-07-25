// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRWebGLLayer: global::Natrix.StdWeb.XRLayer
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRWebGLLayer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.XRWebGLLayer New(global::Natrix.StdWeb.XRSession session, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GenericMarshaller.Union> context)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = session.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = context.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "XRWebGLLayer", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.XRWebGLLayer(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.XRWebGLLayer New(global::Natrix.StdWeb.XRSession session, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GenericMarshaller.Union> context, global::Natrix.StdWeb.XRWebGLLayerInit layerInit)
    {
        int ___argsArrayLength_3 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = session.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = context.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_5);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_6;
        ___marshalledValue_6 = layerInit.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 2, ___marshalledValue_6);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "XRWebGLLayer", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.XRWebGLLayer(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Antialias
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "antialias");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreDepthValues
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ignoreDepthValues");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? FixedFoveation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "fixedFoveation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "fixedFoveation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebGLFramebuffer? Framebuffer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebGLFramebuffer?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "framebuffer");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramebufferWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "framebufferWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramebufferHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "framebufferHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRViewport? GetViewport(global::Natrix.StdWeb.XRView view)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = view.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getViewport", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRViewport?, global::Natrix.StdWeb.PropertyAccessorNullable>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static double GetNativeFramebufferScaleFactor(global::Natrix.StdWeb.XRSession session)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = session.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "XRWebGLLayer"), "getNativeFramebufferScaleFactor", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "XRWebGLLayer"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable