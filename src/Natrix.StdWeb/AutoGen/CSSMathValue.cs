// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSMathValue: global::Natrix.StdWeb.CSSNumericValue
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSMathValue(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSMathOperator Operator
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSMathOperator, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "operator");
    }
}

#nullable disable