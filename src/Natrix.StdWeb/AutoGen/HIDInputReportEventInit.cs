// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HIDInputReportEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<HIDInputReportEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDInputReportEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HIDInputReportEventInit global::Natrix.JSCore.IJSObjectProxy<HIDInputReportEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDInputReportEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.HIDDevice Device
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDevice>.Get(JSObject, "device");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDDevice>.Set(JSObject, "device", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required byte ReportId
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "reportId");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "reportId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.DataView Data
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>.Set(JSObject, "data", value);
    }
}

#nullable disable