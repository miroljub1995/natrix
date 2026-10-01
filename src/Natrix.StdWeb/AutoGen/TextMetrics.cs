// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TextMetrics: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TextMetrics>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextMetrics(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TextMetrics global::Natrix.JSCore.IJSObjectProxy<TextMetrics>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TextMetrics>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Width
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "width");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ActualBoundingBoxLeft
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "actualBoundingBoxLeft");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ActualBoundingBoxRight
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "actualBoundingBoxRight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FontBoundingBoxAscent
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "fontBoundingBoxAscent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FontBoundingBoxDescent
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "fontBoundingBoxDescent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ActualBoundingBoxAscent
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "actualBoundingBoxAscent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ActualBoundingBoxDescent
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "actualBoundingBoxDescent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EmHeightAscent
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "emHeightAscent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EmHeightDescent
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "emHeightDescent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double HangingBaseline
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "hangingBaseline");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AlphabeticBaseline
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "alphabeticBaseline");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double IdeographicBaseline
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "ideographicBaseline");
    }
}

#nullable disable