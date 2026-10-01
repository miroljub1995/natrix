// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HighlightsFromPointOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HighlightsFromPointOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HighlightsFromPointOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HighlightsFromPointOptions global::Natrix.JSCore.IJSObjectProxy<HighlightsFromPointOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HighlightsFromPointOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ShadowRoot, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ShadowRoot>> ShadowRoots
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ShadowRoot, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ShadowRoot>>>.Get(JSObject, "shadowRoots");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ShadowRoot, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ShadowRoot>>>.Set(JSObject, "shadowRoots", value);
    }
}

#nullable disable