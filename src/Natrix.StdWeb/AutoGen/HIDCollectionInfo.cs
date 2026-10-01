// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HIDCollectionInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HIDCollectionInfo>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDCollectionInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HIDCollectionInfo global::Natrix.JSCore.IJSObjectProxy<HIDCollectionInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDCollectionInfo(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort UsagePage
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "usagePage");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "usagePage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Usage
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "usage");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "usage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte Type
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDCollectionInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDCollectionInfo>> Children
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDCollectionInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDCollectionInfo>>>.Get(JSObject, "children");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDCollectionInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDCollectionInfo>>>.Set(JSObject, "children", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportInfo>> InputReports
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportInfo>>>.Get(JSObject, "inputReports");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportInfo>>>.Set(JSObject, "inputReports", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportInfo>> OutputReports
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportInfo>>>.Get(JSObject, "outputReports");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportInfo>>>.Set(JSObject, "outputReports", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportInfo>> FeatureReports
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportInfo>>>.Get(JSObject, "featureReports");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HIDReportInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HIDReportInfo>>>.Set(JSObject, "featureReports", value);
    }
}

#nullable disable