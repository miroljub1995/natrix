// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSMathMin: global::Natrix.StdWeb.CSSMathValue, global::Natrix.JSCore.IJSObjectProxy<CSSMathMin>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSMathMin(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSMathMin global::Natrix.JSCore.IJSObjectProxy<CSSMathMin>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSMathMin>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSMathMin New(params global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>[] args)
    {
        int ___argsArrayLength_3 = args.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        for (int ___i_4 = 0; ___i_4 < args.Length; ___i_4++)
        {
        global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>> ___elem_5 = args[___i_4];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6 = ___elem_5.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_4, ___propObject_6);
        }

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSMathMin", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSMathMin(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSNumericArray Values
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSNumericArray, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericArray>>(JSObject, "values");
    }
}

#nullable disable