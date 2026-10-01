// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BoxQuadOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BoxQuadOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BoxQuadOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BoxQuadOptions global::Natrix.JSCore.IJSObjectProxy<BoxQuadOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BoxQuadOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSBoxType Box
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSBoxType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CSSBoxType>>(JSObject, "box");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CSSBoxType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CSSBoxType>>(JSObject, "box", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>> RelativeTo
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>>>>(JSObject, "relativeTo");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>>>>(JSObject, "relativeTo", value);
    }
}

#nullable disable