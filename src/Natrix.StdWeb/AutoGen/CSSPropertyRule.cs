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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Syntax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "syntax");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Inherits
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "inherits");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? InitialValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "initialValue");
    }
}

#nullable disable