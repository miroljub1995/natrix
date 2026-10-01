// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUCanvasContext: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUCanvasContext>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUCanvasContext(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUCanvasContext global::Natrix.JSCore.IJSObjectProxy<GPUCanvasContext>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUCanvasContext>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCanvasElement, global::Natrix.StdWeb.OffscreenCanvas, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCanvasElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvas>> Canvas
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCanvasElement, global::Natrix.StdWeb.OffscreenCanvas, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCanvasElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OffscreenCanvas>>>.Get(JSObject, "canvas");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Configure(global::Natrix.StdWeb.GPUCanvasConfiguration configuration)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = configuration.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "configure", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Unconfigure()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "unconfigure", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUCanvasConfiguration? GetConfiguration()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getConfiguration", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPUCanvasConfiguration>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTexture GetCurrentTexture()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getCurrentTexture", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable