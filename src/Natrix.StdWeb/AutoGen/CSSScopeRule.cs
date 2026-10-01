// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSScopeRule: global::Natrix.StdWeb.CSSGroupingRule, global::Natrix.JSCore.IJSObjectProxy<CSSScopeRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSScopeRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSScopeRule global::Natrix.JSCore.IJSObjectProxy<CSSScopeRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSScopeRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Start
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "start");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? End
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "end");
    }
}

#nullable disable