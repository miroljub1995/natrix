// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSFontFaceRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSFontFaceRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSFontFaceRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSFontFaceRule global::Natrix.JSCore.IJSObjectProxy<CSSFontFaceRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSFontFaceRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFaceDescriptors Style
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSFontFaceDescriptors, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFaceDescriptors>>(JSObject, "style");
    }
}

#nullable disable