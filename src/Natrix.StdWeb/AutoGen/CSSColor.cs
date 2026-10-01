// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSColor: global::Natrix.StdWeb.CSSColorValue, global::Natrix.JSCore.IJSObjectProxy<CSSColor>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSColor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSColor global::Natrix.JSCore.IJSObjectProxy<CSSColor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSColor>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSColor New(global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> colorSpace, global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>> channels)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = colorSpace.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = channels.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___propObject_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSColor", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSColor(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSColor New(global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> colorSpace, global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>> channels, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>> alpha)
    {
        int ___argsArrayLength_3 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = colorSpace.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = channels.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___propObject_5);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6 = alpha.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 2, ___propObject_6);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSColor", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSColor(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>> ColorSpace
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>.Get(JSObject, "colorSpace");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>.Set(JSObject, "colorSpace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.ObservableArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>> Channels
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.ObservableArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>>>.Get(JSObject, "channels");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.ObservableArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>>>.Set(JSObject, "channels", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>> Alpha
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>>.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>>>.Set(JSObject, "alpha", value);
    }
}

#nullable disable