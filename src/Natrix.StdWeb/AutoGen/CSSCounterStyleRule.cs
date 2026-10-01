// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSCounterStyleRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSCounterStyleRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSCounterStyleRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSCounterStyleRule global::Natrix.JSCore.IJSObjectProxy<CSSCounterStyleRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSCounterStyleRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string System
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "system");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "system", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Symbols
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "symbols");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "symbols", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AdditiveSymbols
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "additiveSymbols");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "additiveSymbols", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Negative
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "negative");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "negative", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Prefix
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "prefix");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "prefix", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Suffix
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "suffix");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "suffix", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Range
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "range");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "range", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Pad
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "pad");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "pad", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SpeakAs
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "speakAs");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "speakAs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Fallback
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "fallback");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "fallback", value);
    }
}

#nullable disable