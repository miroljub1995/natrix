// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBConfiguration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<USBConfiguration>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static USBConfiguration global::Natrix.JSCore.IJSObjectProxy<USBConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<USBConfiguration>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.USBConfiguration New(global::Natrix.StdWeb.USBDevice device, byte configurationValue)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = device.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(configurationValue);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "USBConfiguration", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.USBConfiguration(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte ConfigurationValue
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "configurationValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? ConfigurationName
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "configurationName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBInterface, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBInterface>> Interfaces
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBInterface, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBInterface>>>.Get(JSObject, "interfaces");
    }
}

#nullable disable