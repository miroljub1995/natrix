// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGPoint: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGPoint>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGPoint(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGPoint global::Natrix.JSCore.IJSObjectProxy<SVGPoint>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGPoint>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float X
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "x");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "x", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Y
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "y");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "y", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGPoint MatrixTransform(global::Natrix.StdWeb.SVGMatrix matrix)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = matrix.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "matrixTransform", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGPoint>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable