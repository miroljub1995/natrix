// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSContainerRule: global::Natrix.StdWeb.CSSConditionRule, global::Natrix.JSCore.IJSObjectProxy<CSSContainerRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSContainerRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSContainerRule global::Natrix.JSCore.IJSObjectProxy<CSSContainerRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSContainerRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContainerName
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "containerName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContainerQuery
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "containerQuery");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSContainerCondition, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSContainerCondition>> Conditions
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSContainerCondition, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSContainerCondition>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSContainerCondition, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSContainerCondition>>>>(JSObject, "conditions");
    }
}

#nullable disable