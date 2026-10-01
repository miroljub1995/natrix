// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSStyleSheetInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CSSStyleSheetInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSStyleSheetInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSStyleSheetInit global::Natrix.JSCore.IJSObjectProxy<CSSStyleSheetInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSStyleSheetInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? BaseURL
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "baseURL");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "baseURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaList, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>, global::Natrix.JSCore.Generics.StringAccessor> Media
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaList, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaList, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "media");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaList, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaList, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "media", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Disabled
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "disabled");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "disabled", value);
    }
}

#nullable disable