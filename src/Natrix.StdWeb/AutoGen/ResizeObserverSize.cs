// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ResizeObserverSize: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ResizeObserverSize(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double InlineSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "inlineSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BlockSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "blockSize");
    }
}

#nullable disable