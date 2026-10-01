// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CountQueuingStrategy: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CountQueuingStrategy>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CountQueuingStrategy(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CountQueuingStrategy global::Natrix.JSCore.IJSObjectProxy<CountQueuingStrategy>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CountQueuingStrategy>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CountQueuingStrategy New(global::Natrix.StdWeb.QueuingStrategyInit init)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CountQueuingStrategy", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CountQueuingStrategy(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double HighWaterMark
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "highWaterMark");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Function Size
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Function>.Get(JSObject, "size");
    }
}

#nullable disable