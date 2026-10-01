// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRLightEstimate: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRLightEstimate>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRLightEstimate(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRLightEstimate global::Natrix.JSCore.IJSObjectProxy<XRLightEstimate>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRLightEstimate>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array SphericalHarmonicsCoefficients
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>.Get(JSObject, "sphericalHarmonicsCoefficients");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly PrimaryLightDirection
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Get(JSObject, "primaryLightDirection");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly PrimaryLightIntensity
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Get(JSObject, "primaryLightIntensity");
    }
}

#nullable disable