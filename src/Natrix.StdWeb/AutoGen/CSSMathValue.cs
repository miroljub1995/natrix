// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSMathValue: global::Natrix.StdWeb.CSSNumericValue, global::Natrix.JSCore.IJSObjectProxy<CSSMathValue>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSMathValue(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSMathValue global::Natrix.JSCore.IJSObjectProxy<CSSMathValue>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSMathValue>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSMathOperator Operator
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSMathOperator, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CSSMathOperator>>(JSObject, "operator");
    }
}

#nullable disable