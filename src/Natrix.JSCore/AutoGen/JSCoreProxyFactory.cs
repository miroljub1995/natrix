// ReSharper disable All

namespace Natrix.JSCore;

#nullable enable

public static partial class JSCoreProxyFactory
{
    private static int _isInitialized;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static async Task InitializeAsync()
    {
        if (Interlocked.CompareExchange(ref _isInitialized, 1, 0) != 0)
        {
            return;
        }

        await global::Natrix.JSCore.JSCoreShims.InitializeAsync();

        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ArrayBuffer", obj => new ArrayBuffer(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "DataView", obj => new DataView(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Int8Array", obj => new Int8Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Uint8Array", obj => new Uint8Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Uint8ClampedArray", obj => new Uint8ClampedArray(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Int16Array", obj => new Int16Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Uint16Array", obj => new Uint16Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Int32Array", obj => new Int32Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Uint32Array", obj => new Uint32Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Float16Array", obj => new Float16Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Float32Array", obj => new Float32Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Float64Array", obj => new Float64Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "BigInt64Array", obj => new BigInt64Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "BigUint64Array", obj => new BigUint64Array(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Promise", obj => new Promise(obj));
        global::Natrix.JSCore.JSObjectProxyFactory.AddConstructorFromProp(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SharedArrayBuffer", obj => new SharedArrayBuffer(obj));
    }
}

#nullable disable