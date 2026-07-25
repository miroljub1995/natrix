// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSNestedDeclarations: global::Natrix.StdWeb.CSSRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSNestedDeclarations(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleProperties Style
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSStyleProperties, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "style");
    }
}

#nullable disable