// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BoxQuadOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BoxQuadOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BoxQuadOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSBoxType Box
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSBoxType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "box");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CSSBoxType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "box", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union> RelativeTo
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "relativeTo");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "relativeTo", value);
    }
}

#nullable disable