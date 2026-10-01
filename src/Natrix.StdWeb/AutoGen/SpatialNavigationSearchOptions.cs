// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpatialNavigationSearchOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SpatialNavigationSearchOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpatialNavigationSearchOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpatialNavigationSearchOptions global::Natrix.JSCore.IJSObjectProxy<SpatialNavigationSearchOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpatialNavigationSearchOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>>? Candidates
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>>?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>>>>(JSObject, "candidates");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>>?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>>>>(JSObject, "candidates", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? Container
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>>(JSObject, "container");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.Node?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>>(JSObject, "container", value);
    }
}

#nullable disable