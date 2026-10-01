// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUAdapter: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUAdapter>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUAdapter(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUAdapter global::Natrix.JSCore.IJSObjectProxy<GPUAdapter>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUAdapter>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUSupportedFeatures Features
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUSupportedFeatures, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUSupportedFeatures>>(JSObject, "features");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUSupportedLimits Limits
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUSupportedLimits, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUSupportedLimits>>(JSObject, "limits");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUAdapterInfo Info
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUAdapterInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUAdapterInfo>>(JSObject, "info");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.GPUDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUDevice>> RequestDevice()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "requestDevice", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.GPUDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUDevice>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.GPUDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUDevice>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.GPUDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUDevice>> RequestDevice(global::Natrix.StdWeb.GPUDeviceDescriptor descriptor)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = descriptor.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "requestDevice", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.GPUDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUDevice>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.GPUDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUDevice>>>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable