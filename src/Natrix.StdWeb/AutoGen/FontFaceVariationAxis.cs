// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FontFaceVariationAxis: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FontFaceVariationAxis(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AxisTag
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "axisTag");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MinimumValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "minimumValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MaximumValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maximumValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DefaultValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "defaultValue");
    }
}

#nullable disable