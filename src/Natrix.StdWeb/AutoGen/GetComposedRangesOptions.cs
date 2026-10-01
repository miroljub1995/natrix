// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GetComposedRangesOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GetComposedRangesOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GetComposedRangesOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GetComposedRangesOptions global::Natrix.JSCore.IJSObjectProxy<GetComposedRangesOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GetComposedRangesOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
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