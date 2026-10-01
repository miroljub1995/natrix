// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FontMetrics: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FontMetrics>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FontMetrics(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FontMetrics global::Natrix.JSCore.IJSObjectProxy<FontMetrics>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<FontMetrics>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "width");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.JSCore.Generics.DoubleAccessor> Advances
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "advances");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BoundingBoxLeft
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "boundingBoxLeft");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BoundingBoxRight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "boundingBoxRight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Height
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "height");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EmHeightAscent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "emHeightAscent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EmHeightDescent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "emHeightDescent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BoundingBoxAscent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "boundingBoxAscent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BoundingBoxDescent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "boundingBoxDescent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FontBoundingBoxAscent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "fontBoundingBoxAscent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FontBoundingBoxDescent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "fontBoundingBoxDescent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Baseline DominantBaseline
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Baseline, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Baseline>>(JSObject, "dominantBaseline");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Baseline, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Baseline>> Baselines
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Baseline, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Baseline>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Baseline, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Baseline>>>>(JSObject, "baselines");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Font, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Font>> Fonts
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Font, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Font>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Font, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Font>>>>(JSObject, "fonts");
    }
}

#nullable disable