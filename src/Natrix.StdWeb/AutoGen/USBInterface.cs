// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBInterface: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<USBInterface>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBInterface(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static USBInterface global::Natrix.JSCore.IJSObjectProxy<USBInterface>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<USBInterface>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.USBInterface New(global::Natrix.StdWeb.USBConfiguration configuration, byte interfaceNumber)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = configuration.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(interfaceNumber);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "USBInterface", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.USBInterface(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte InterfaceNumber
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "interfaceNumber");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.USBAlternateInterface Alternate
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBAlternateInterface>.Get(JSObject, "alternate");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBAlternateInterface, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBAlternateInterface>> Alternates
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBAlternateInterface, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBAlternateInterface>>>.Get(JSObject, "alternates");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Claimed
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "claimed");
    }
}

#nullable disable