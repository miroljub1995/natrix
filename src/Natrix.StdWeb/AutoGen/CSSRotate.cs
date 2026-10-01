// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSRotate: global::Natrix.StdWeb.CSSTransformComponent, global::Natrix.JSCore.IJSObjectProxy<CSSRotate>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSRotate(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSRotate global::Natrix.JSCore.IJSObjectProxy<CSSRotate>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSRotate>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSRotate New(global::Natrix.StdWeb.CSSNumericValue angle)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = angle.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSRotate", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSRotate(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSRotate New(global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>> x, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>> y, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>> z, global::Natrix.StdWeb.CSSNumericValue angle)
    {
        int ___argsArrayLength_3 = 4;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = x.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = y.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_5);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6 = z.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 2, ___propObject_6);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_7;
        ___marshalledValue_7 = angle.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 3, ___marshalledValue_7);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSRotate", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSRotate(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>> X
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>>.Get(JSObject, "x");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>>.Set(JSObject, "x", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>> Y
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>>.Get(JSObject, "y");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>>.Set(JSObject, "y", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>> Z
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>>.Get(JSObject, "z");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>>.Set(JSObject, "z", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSNumericValue Angle
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>.Get(JSObject, "angle");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>.Set(JSObject, "angle", value);
    }
}

#nullable disable