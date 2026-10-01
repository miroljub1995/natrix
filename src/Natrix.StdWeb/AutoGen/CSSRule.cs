// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSRule: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CSSRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSRule global::Natrix.JSCore.IJSObjectProxy<CSSRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSRule>(obj);

    public const ushort KEYFRAMES_RULE = 7;

    public const ushort KEYFRAME_RULE = 8;

    public const ushort SUPPORTS_RULE = 12;

    public const ushort COUNTER_STYLE_RULE = 11;

    public const ushort FONT_FEATURE_VALUES_RULE = 14;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CssText
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "cssText");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "cssText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSRule? ParentRule
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSRule?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CSSRule>>(JSObject, "parentRule");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleSheet? ParentStyleSheet
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSStyleSheet?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CSSStyleSheet>>(JSObject, "parentStyleSheet");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>(JSObject, "type");
    }

    public const ushort STYLE_RULE = 1;

    public const ushort CHARSET_RULE = 2;

    public const ushort IMPORT_RULE = 3;

    public const ushort MEDIA_RULE = 4;

    public const ushort FONT_FACE_RULE = 5;

    public const ushort PAGE_RULE = 6;

    public const ushort MARGIN_RULE = 9;

    public const ushort NAMESPACE_RULE = 10;
}

#nullable disable