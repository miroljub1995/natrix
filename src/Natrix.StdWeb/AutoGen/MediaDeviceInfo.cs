// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaDeviceInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaDeviceInfo>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaDeviceInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaDeviceInfo global::Natrix.JSCore.IJSObjectProxy<MediaDeviceInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MediaDeviceInfo>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DeviceId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "deviceId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaDeviceKind Kind
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaDeviceKind>.Get(JSObject, "kind");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string GroupId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "groupId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable