// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSFontFaceRule: global::Natrix.StdWeb.CSSRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSFontFaceRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFaceDescriptors Style
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSFontFaceDescriptors, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "style");
    }
}

#nullable disable