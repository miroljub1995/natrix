// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBIsochronousInTransferPacket: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<USBIsochronousInTransferPacket>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBIsochronousInTransferPacket(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static USBIsochronousInTransferPacket global::Natrix.JSCore.IJSObjectProxy<USBIsochronousInTransferPacket>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<USBIsochronousInTransferPacket>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.USBIsochronousInTransferPacket New(global::Natrix.StdWeb.USBTransferStatus status)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = status.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "USBIsochronousInTransferPacket", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.USBIsochronousInTransferPacket(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.USBIsochronousInTransferPacket New(global::Natrix.StdWeb.USBTransferStatus status, global::Natrix.JSCore.DataView? data)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = status.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_5;
        if (data is null)
        {
            ___marshalledValue_5 = null;
        }
        else
        {
            global::Natrix.JSCore.DataView ___notNullable_6 = (global::Natrix.JSCore.DataView)data;
            ___marshalledValue_5 = ___notNullable_6.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "USBIsochronousInTransferPacket", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.USBIsochronousInTransferPacket(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.DataView? Data
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.DataView>.Get(JSObject, "data");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.USBTransferStatus Status
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.USBTransferStatus>.Get(JSObject, "status");
    }
}

#nullable disable