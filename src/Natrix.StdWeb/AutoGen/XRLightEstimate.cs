// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRLightEstimate: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRLightEstimate(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Float32Array SphericalHarmonicsCoefficients
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Float32Array, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sphericalHarmonicsCoefficients");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly PrimaryLightDirection
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMPointReadOnly, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "primaryLightDirection");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly PrimaryLightIntensity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMPointReadOnly, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "primaryLightIntensity");
    }
}

#nullable disable