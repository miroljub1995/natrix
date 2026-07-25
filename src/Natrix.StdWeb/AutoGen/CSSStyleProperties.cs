// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSStyleProperties: global::Natrix.StdWeb.CSSStyleDeclaration
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSStyleProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CssFloat
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cssFloat");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cssFloat", value);
    }
}

#nullable disable