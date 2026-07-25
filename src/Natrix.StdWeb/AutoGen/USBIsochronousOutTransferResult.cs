// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBIsochronousOutTransferResult: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBIsochronousOutTransferResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.USBIsochronousOutTransferResult New(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.USBIsochronousOutTransferPacket, global::Natrix.StdWeb.PropertyAccessor> packets)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = packets.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___propObject_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "USBIsochronousOutTransferResult", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.USBIsochronousOutTransferResult(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBIsochronousOutTransferPacket, global::Natrix.StdWeb.PropertyAccessor> Packets
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBIsochronousOutTransferPacket, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packets");
    }
}

#nullable disable