// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FontFaceVariationAxis: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FontFaceVariationAxis>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FontFaceVariationAxis(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FontFaceVariationAxis global::Natrix.JSCore.IJSObjectProxy<FontFaceVariationAxis>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<FontFaceVariationAxis>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AxisTag
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "axisTag");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MinimumValue
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "minimumValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MaximumValue
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "maximumValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DefaultValue
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "defaultValue");
    }
}

#nullable disable