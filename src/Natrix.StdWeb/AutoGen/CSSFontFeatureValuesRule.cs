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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "fontFamily");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "fontFamily", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap Annotation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSFontFeatureValuesMap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>>(JSObject, "annotation");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap Ornaments
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSFontFeatureValuesMap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>>(JSObject, "ornaments");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap Stylistic
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSFontFeatureValuesMap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>>(JSObject, "stylistic");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap Swash
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSFontFeatureValuesMap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>>(JSObject, "swash");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap CharacterVariant
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSFontFeatureValuesMap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>>(JSObject, "characterVariant");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap Styleset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSFontFeatureValuesMap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>>(JSObject, "styleset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSFontFeatureValuesMap HistoricalForms
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSFontFeatureValuesMap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSFontFeatureValuesMap>>(JSObject, "historicalForms");
    }
}

#nullable disable