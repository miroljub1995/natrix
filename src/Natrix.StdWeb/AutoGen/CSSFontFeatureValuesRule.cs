// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSFontFeatureValuesRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSFontFeatureValuesRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSFontFeatureValuesRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSFontFeatureValuesRule global::Natrix.JSCore.IJSObjectProxy<CSSFontFeatureValuesRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSFontFeatureValuesRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FontFamily
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "fontFamily");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "fontFamily", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap Annotation
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>.Get(JSObject, "annotation");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap Ornaments
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>.Get(JSObject, "ornaments");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap Stylistic
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>.Get(JSObject, "stylistic");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap Swash
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>.Get(JSObject, "swash");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap CharacterVariant
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>.Get(JSObject, "characterVariant");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap Styleset
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>.Get(JSObject, "styleset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap HistoricalForms
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>.Get(JSObject, "historicalForms");
    }
}

#nullable disable