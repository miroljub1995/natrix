// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSParserQualifiedRule: global::Natrix.StdWeb.CSSParserRule, global::Natrix.JSCore.IJSObjectProxy<CSSParserQualifiedRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSParserQualifiedRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSParserQualifiedRule global::Natrix.JSCore.IJSObjectProxy<CSSParserQualifiedRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSParserQualifiedRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSParserQualifiedRule New(global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.CSSStyleValue, global::Natrix.StdWeb.CSSParserValue, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSStyleValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSParserValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.CSSStyleValue, global::Natrix.StdWeb.CSSParserValue, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSStyleValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSParserValue>>>> prelude)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = prelude.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___propObject_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSParserQualifiedRule", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSParserQualifiedRule(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSParserQualifiedRule New(global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.CSSStyleValue, global::Natrix.StdWeb.CSSParserValue, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSStyleValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSParserValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.CSSStyleValue, global::Natrix.StdWeb.CSSParserValue, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSStyleValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSParserValue>>>> prelude, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSParserRule>>? body)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = prelude.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_5;
        if (body is null)
        {
            ___propObject_5 = null;
        }
        else
        {
            ___propObject_5 = body.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 1, ___propObject_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSParserQualifiedRule", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSParserQualifiedRule(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSParserValue>> Prelude
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSParserValue>>>.Get(JSObject, "prelude");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSParserRule>> Body
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSParserRule>>>.Get(JSObject, "body");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void _()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "", JSObject, ___resOwner_1.JSObject);
    }
}

#nullable disable