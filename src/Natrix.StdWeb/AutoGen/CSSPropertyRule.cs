// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSPropertyRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSPropertyRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSPropertyRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSPropertyRule global::Natrix.JSCore.IJSObjectProxy<CSSPropertyRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSPropertyRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Syntax
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "syntax");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Inherits
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "inherits");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? InitialValue
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "initialValue");
    }
}

#nullable disable