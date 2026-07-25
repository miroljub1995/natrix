// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TextMetrics: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextMetrics(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ActualBoundingBoxLeft
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "actualBoundingBoxLeft");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ActualBoundingBoxRight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "actualBoundingBoxRight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FontBoundingBoxAscent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fontBoundingBoxAscent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FontBoundingBoxDescent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fontBoundingBoxDescent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ActualBoundingBoxAscent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "actualBoundingBoxAscent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ActualBoundingBoxDescent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "actualBoundingBoxDescent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EmHeightAscent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "emHeightAscent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EmHeightDescent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "emHeightDescent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double HangingBaseline
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hangingBaseline");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AlphabeticBaseline
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "alphabeticBaseline");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double IdeographicBaseline
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ideographicBaseline");
    }
}

#nullable disable