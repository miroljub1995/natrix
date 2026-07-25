// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSFunctionDeclarations: global::Natrix.StdWeb.CSSRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSFunctionDeclarations(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFunctionDescriptors Style
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSFunctionDescriptors, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "style");
    }
}

#nullable disable