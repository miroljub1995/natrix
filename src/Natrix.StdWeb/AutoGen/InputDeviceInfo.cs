// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class InputDeviceInfo: global::Natrix.StdWeb.MediaDeviceInfo, global::Natrix.JSCore.IJSObjectProxy<InputDeviceInfo>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InputDeviceInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static InputDeviceInfo global::Natrix.JSCore.IJSObjectProxy<InputDeviceInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<InputDeviceInfo>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaTrackCapabilities GetCapabilities()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getCapabilities", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaTrackCapabilities, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackCapabilities>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable