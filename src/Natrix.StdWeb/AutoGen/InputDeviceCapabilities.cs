// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class InputDeviceCapabilities: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<InputDeviceCapabilities>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InputDeviceCapabilities(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static InputDeviceCapabilities global::Natrix.JSCore.IJSObjectProxy<InputDeviceCapabilities>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<InputDeviceCapabilities>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.InputDeviceCapabilities New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "InputDeviceCapabilities");
        return new global::Natrix.StdWeb.InputDeviceCapabilities(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.InputDeviceCapabilities New(global::Natrix.StdWeb.InputDeviceCapabilitiesInit deviceInitDict)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = deviceInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "InputDeviceCapabilities", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.InputDeviceCapabilities(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool FiresTouchEvents
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "firesTouchEvents");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PointerMovementScrolls
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "pointerMovementScrolls");
    }
}

#nullable disable