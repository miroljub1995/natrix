// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBAlternateInterface: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<USBAlternateInterface>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBAlternateInterface(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static USBAlternateInterface global::Natrix.JSCore.IJSObjectProxy<USBAlternateInterface>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<USBAlternateInterface>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.USBAlternateInterface New(global::Natrix.StdWeb.USBInterface deviceInterface, byte alternateSetting)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = deviceInterface.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(alternateSetting);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "USBAlternateInterface", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.USBAlternateInterface(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte AlternateSetting
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "alternateSetting");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte InterfaceClass
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "interfaceClass");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte InterfaceSubclass
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "interfaceSubclass");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte InterfaceProtocol
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "interfaceProtocol");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? InterfaceName
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "interfaceName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBEndpoint, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBEndpoint>> Endpoints
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBEndpoint, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBEndpoint>>>.Get(JSObject, "endpoints");
    }
}

#nullable disable