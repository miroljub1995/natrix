// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RouterRule: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RouterRule>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RouterRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RouterRule global::Natrix.JSCore.IJSObjectProxy<RouterRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RouterRule(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RouterCondition Condition
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RouterCondition, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterCondition>>(JSObject, "condition");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RouterCondition, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterCondition>>(JSObject, "condition", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RouterSourceDict, global::Natrix.StdWeb.RouterSourceEnum, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterSourceDict>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RouterSourceEnum>> Source
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RouterSourceDict, global::Natrix.StdWeb.RouterSourceEnum, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterSourceDict>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RouterSourceEnum>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RouterSourceDict, global::Natrix.StdWeb.RouterSourceEnum, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterSourceDict>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RouterSourceEnum>>>>(JSObject, "source");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RouterSourceDict, global::Natrix.StdWeb.RouterSourceEnum, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterSourceDict>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RouterSourceEnum>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RouterSourceDict, global::Natrix.StdWeb.RouterSourceEnum, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterSourceDict>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RouterSourceEnum>>>>(JSObject, "source", value);
    }
}

#nullable disable