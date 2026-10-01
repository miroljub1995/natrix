// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RouterCondition: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RouterCondition>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RouterCondition(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RouterCondition global::Natrix.JSCore.IJSObjectProxy<RouterCondition>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RouterCondition(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.StdWeb.URLPattern, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPattern>> UrlPattern
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.StdWeb.URLPattern, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPattern>>>.Get(JSObject, "urlPattern");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.StdWeb.URLPattern, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPattern>>>.Set(JSObject, "urlPattern", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RequestMethod
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "requestMethod");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "requestMethod", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RequestMode RequestMode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RequestMode>.Get(JSObject, "requestMode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RequestMode>.Set(JSObject, "requestMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RequestDestination RequestDestination
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RequestDestination>.Get(JSObject, "requestDestination");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RequestDestination>.Set(JSObject, "requestDestination", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RunningStatus RunningStatus
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RunningStatus>.Get(JSObject, "runningStatus");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RunningStatus>.Set(JSObject, "runningStatus", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RouterCondition, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterCondition>> Or
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RouterCondition, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterCondition>>>.Get(JSObject, "or");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RouterCondition, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterCondition>>>.Set(JSObject, "or", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RouterCondition Not
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterCondition>.Get(JSObject, "not");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RouterCondition>.Set(JSObject, "not", value);
    }
}

#nullable disable