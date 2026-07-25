// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IntrinsicSizes: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntrinsicSizes(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MinContentSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "minContentSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MaxContentSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxContentSize");
    }
}

#nullable disable