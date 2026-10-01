// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HighlightHitResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HighlightHitResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HighlightHitResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HighlightHitResult global::Natrix.JSCore.IJSObjectProxy<HighlightHitResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HighlightHitResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Highlight Highlight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Highlight, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Highlight>>(JSObject, "highlight");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.Highlight, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Highlight>>(JSObject, "highlight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AbstractRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbstractRange>> Ranges
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AbstractRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbstractRange>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AbstractRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbstractRange>>>>(JSObject, "ranges");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AbstractRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbstractRange>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AbstractRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbstractRange>>>>(JSObject, "ranges", value);
    }
}

#nullable disable