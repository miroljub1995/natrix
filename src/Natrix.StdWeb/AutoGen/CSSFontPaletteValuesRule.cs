// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSFontPaletteValuesRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSFontPaletteValuesRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSFontPaletteValuesRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSFontPaletteValuesRule global::Natrix.JSCore.IJSObjectProxy<CSSFontPaletteValuesRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSFontPaletteValuesRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FontFamily
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "fontFamily");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string BasePalette
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "basePalette");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string OverrideColors
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "overrideColors");
    }
}

#nullable disable