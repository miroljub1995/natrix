// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebGLShaderPrecisionFormat: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebGLShaderPrecisionFormat>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebGLShaderPrecisionFormat(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebGLShaderPrecisionFormat global::Natrix.JSCore.IJSObjectProxy<WebGLShaderPrecisionFormat>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WebGLShaderPrecisionFormat>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int RangeMin
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "rangeMin");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int RangeMax
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "rangeMax");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Precision
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "precision");
    }
}

#nullable disable