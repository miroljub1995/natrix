// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DeviceChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<DeviceChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DeviceChangeEventInit global::Natrix.JSCore.IJSObjectProxy<DeviceChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DeviceChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaDeviceInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaDeviceInfo>> Devices
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaDeviceInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaDeviceInfo>>>.Get(JSObject, "devices");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaDeviceInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaDeviceInfo>>>.Set(JSObject, "devices", value);
    }
}

#nullable disable