// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSLayerBlockRule: global::Natrix.StdWeb.CSSGroupingRule, global::Natrix.JSCore.IJSObjectProxy<CSSLayerBlockRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSLayerBlockRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSLayerBlockRule global::Natrix.JSCore.IJSObjectProxy<CSSLayerBlockRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSLayerBlockRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "name");
    }
}

#nullable disable