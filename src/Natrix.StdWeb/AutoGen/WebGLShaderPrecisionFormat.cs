// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebGLShaderPrecisionFormat: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebGLShaderPrecisionFormat(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int RangeMin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rangeMin");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int RangeMax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rangeMax");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Precision
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "precision");
    }
}

#nullable disable