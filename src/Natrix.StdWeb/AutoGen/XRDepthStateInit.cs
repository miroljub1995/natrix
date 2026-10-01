// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRDepthStateInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRDepthStateInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRDepthStateInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRDepthStateInit global::Natrix.JSCore.IJSObjectProxy<XRDepthStateInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRDepthStateInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRDepthUsage, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRDepthUsage>> UsagePreference
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRDepthUsage, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRDepthUsage>>>.Get(JSObject, "usagePreference");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRDepthUsage, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRDepthUsage>>>.Set(JSObject, "usagePreference", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRDepthDataFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRDepthDataFormat>> DataFormatPreference
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRDepthDataFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRDepthDataFormat>>>.Get(JSObject, "dataFormatPreference");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRDepthDataFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRDepthDataFormat>>>.Set(JSObject, "dataFormatPreference", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRDepthType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRDepthType>> DepthTypeRequest
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRDepthType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRDepthType>>>.Get(JSObject, "depthTypeRequest");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRDepthType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRDepthType>>>.Set(JSObject, "depthTypeRequest", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool MatchDepthView
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "matchDepthView");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "matchDepthView", value);
    }
}

#nullable disable