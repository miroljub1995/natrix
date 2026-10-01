// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRSessionInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRSessionInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRSessionInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRSessionInit global::Natrix.JSCore.IJSObjectProxy<XRSessionInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRSessionInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRDepthStateInit DepthSensing
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRDepthStateInit>.Get(JSObject, "depthSensing");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRDepthStateInit>.Set(JSObject, "depthSensing", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRDOMOverlayInit? DomOverlay
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRDOMOverlayInit>.Get(JSObject, "domOverlay");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRDOMOverlayInit>.Set(JSObject, "domOverlay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> RequiredFeatures
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "requiredFeatures");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "requiredFeatures", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> OptionalFeatures
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "optionalFeatures");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "optionalFeatures", value);
    }
}

#nullable disable