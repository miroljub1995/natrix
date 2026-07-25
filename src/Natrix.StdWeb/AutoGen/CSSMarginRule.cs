// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSMarginRule: global::Natrix.StdWeb.CSSRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSMarginRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleDeclaration Style
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSStyleDeclaration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "style");
    }
}

#nullable disable