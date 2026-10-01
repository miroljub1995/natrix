// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSRGB: global::Natrix.StdWeb.CSSColorValue, global::Natrix.JSCore.IJSObjectProxy<CSSRGB>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSRGB(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSRGB global::Natrix.JSCore.IJSObjectProxy<CSSRGB>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSRGB>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSRGB New(global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> r, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> g, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> b)
    {
        int ___argsArrayLength_3 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = r.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = g.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_5);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6 = b.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 2, ___propObject_6);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSRGB", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSRGB(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSRGB New(global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> r, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> g, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> b, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> alpha)
    {
        int ___argsArrayLength_3 = 4;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = r.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = g.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_5);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6 = b.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 2, ___propObject_6);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_7 = alpha.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 3, ___propObject_7);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSRGB", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSRGB(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> R
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>.Get(JSObject, "r");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>.Set(JSObject, "r", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> G
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>.Get(JSObject, "g");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>.Set(JSObject, "g", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> B
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>.Get(JSObject, "b");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>.Set(JSObject, "b", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> Alpha
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>.Set(JSObject, "alpha", value);
    }
}

#nullable disable