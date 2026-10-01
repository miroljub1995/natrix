// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothRemoteGATTServer: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BluetoothRemoteGATTServer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothRemoteGATTServer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothRemoteGATTServer global::Natrix.JSCore.IJSObjectProxy<BluetoothRemoteGATTServer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BluetoothRemoteGATTServer>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BluetoothDevice Device
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothDevice>.Get(JSObject, "device");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Connected
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "connected");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.BluetoothRemoteGATTServer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTServer>> Connect()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "connect", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.BluetoothRemoteGATTServer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTServer>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Disconnect()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "disconnect", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.BluetoothRemoteGATTService, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTService>> GetPrimaryService(global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor> service)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = service.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getPrimaryService", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.BluetoothRemoteGATTService, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTService>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothRemoteGATTService, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTService>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothRemoteGATTService, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTService>>>> GetPrimaryServices()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getPrimaryServices", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothRemoteGATTService, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTService>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothRemoteGATTService, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTService>>>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothRemoteGATTService, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTService>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothRemoteGATTService, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTService>>>> GetPrimaryServices(global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor> service)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = service.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getPrimaryServices", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothRemoteGATTService, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTService>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothRemoteGATTService, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTService>>>>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable