// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LargestContentfulPaint: global::Natrix.StdWeb.PerformanceEntry, global::Natrix.JSCore.IJSObjectProxy<LargestContentfulPaint>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LargestContentfulPaint(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LargestContentfulPaint global::Natrix.JSCore.IJSObjectProxy<LargestContentfulPaint>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LargestContentfulPaint>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LoadTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "loadTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RenderTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "renderTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Size
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "size");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Url
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "url");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? Element
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "element");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PaintTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "paintTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? PresentationTime
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "presentationTime");
    }
}

#nullable disable