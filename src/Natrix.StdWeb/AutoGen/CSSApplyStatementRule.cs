// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSApplyStatementRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSApplyStatementRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSApplyStatementRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSApplyStatementRule global::Natrix.JSCore.IJSObjectProxy<CSSApplyStatementRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSApplyStatementRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> GetArguments()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getArguments", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable