// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothDataFilter: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BluetoothDataFilter>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothDataFilter(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothDataFilter global::Natrix.JSCore.IJSObjectProxy<BluetoothDataFilter>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BluetoothDataFilter>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.BluetoothDataFilter New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "BluetoothDataFilter");
        return new global::Natrix.StdWeb.BluetoothDataFilter(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.BluetoothDataFilter New(global::Natrix.StdWeb.BluetoothDataFilterInit init)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "BluetoothDataFilter", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.BluetoothDataFilter(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer DataPrefix
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "dataPrefix");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer Mask
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "mask");
    }
}

#nullable disable