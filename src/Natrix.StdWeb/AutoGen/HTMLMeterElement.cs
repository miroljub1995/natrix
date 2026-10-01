// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLMeterElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLMeterElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLMeterElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLMeterElement global::Natrix.JSCore.IJSObjectProxy<HTMLMeterElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLMeterElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLMeterElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLMeterElement");
        return new global::Natrix.StdWeb.HTMLMeterElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Value
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "value");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Min
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "min");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "min", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Max
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "max");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "max", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Low
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "low");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "low", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double High
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "high");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "high", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Optimum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "optimum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "optimum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NodeList Labels
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NodeList, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NodeList>>(JSObject, "labels");
    }
}

#nullable disable