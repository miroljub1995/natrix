// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBIsochronousOutTransferPacket: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<USBIsochronousOutTransferPacket>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBIsochronousOutTransferPacket(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static USBIsochronousOutTransferPacket global::Natrix.JSCore.IJSObjectProxy<USBIsochronousOutTransferPacket>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<USBIsochronousOutTransferPacket>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.USBIsochronousOutTransferPacket New(global::Natrix.StdWeb.USBTransferStatus status)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = status.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "USBIsochronousOutTransferPacket", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.USBIsochronousOutTransferPacket(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.USBIsochronousOutTransferPacket New(global::Natrix.StdWeb.USBTransferStatus status, uint bytesWritten)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = status.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(bytesWritten);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "USBIsochronousOutTransferPacket", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.USBIsochronousOutTransferPacket(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint BytesWritten
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "bytesWritten");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.USBTransferStatus Status
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.USBTransferStatus>.Get(JSObject, "status");
    }
}

#nullable disable