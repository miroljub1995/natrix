// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HIDReportInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HIDReportInfo>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDReportInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HIDReportInfo global::Natrix.JSCore.IJSObjectProxy<HIDReportInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDReportInfo(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte ReportId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte, global::Natrix.JSCore.Generics.ByteAccessor>(JSObject, "reportId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<byte, global::Natrix.JSCore.Generics.ByteAccessor>(JSObject, "reportId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportItem>> Items
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportItem>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportItem>>>>(JSObject, "items");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportItem>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportItem>>>>(JSObject, "items", value);
    }
}

#nullable disable