// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSPositionTryRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSPositionTryRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSPositionTryRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSPositionTryRule global::Natrix.JSCore.IJSObjectProxy<CSSPositionTryRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSPositionTryRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSPositionTryDescriptors Style
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSPositionTryDescriptors, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPositionTryDescriptors>>(JSObject, "style");
    }
}

#nullable disable