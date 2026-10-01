// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ResizeObserverSize: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ResizeObserverSize>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ResizeObserverSize(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ResizeObserverSize global::Natrix.JSCore.IJSObjectProxy<ResizeObserverSize>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ResizeObserverSize>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double InlineSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "inlineSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double BlockSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "blockSize");
    }
}

#nullable disable