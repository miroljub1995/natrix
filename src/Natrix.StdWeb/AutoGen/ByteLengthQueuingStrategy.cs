// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ByteLengthQueuingStrategy: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ByteLengthQueuingStrategy(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ByteLengthQueuingStrategy New(global::Natrix.StdWeb.QueuingStrategyInit init)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ByteLengthQueuingStrategy", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ByteLengthQueuingStrategy(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double HighWaterMark
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "highWaterMark");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Function Size
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Function, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "size");
    }
}

#nullable disable