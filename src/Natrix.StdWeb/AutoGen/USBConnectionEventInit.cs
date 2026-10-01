// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBConnectionEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<USBConnectionEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBConnectionEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static USBConnectionEventInit global::Natrix.JSCore.IJSObjectProxy<USBConnectionEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBConnectionEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.USBDevice Device
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDevice>.Get(JSObject, "device");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDevice>.Set(JSObject, "device", value);
    }
}

#nullable disable