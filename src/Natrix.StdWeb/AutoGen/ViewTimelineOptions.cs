// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ViewTimelineOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ViewTimelineOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ViewTimelineOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ViewTimelineOptions global::Natrix.JSCore.IJSObjectProxy<ViewTimelineOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ViewTimelineOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element Subject
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "subject");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>.Set(JSObject, "subject", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScrollAxis Axis
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScrollAxis>.Get(JSObject, "axis");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ScrollAxis>.Set(JSObject, "axis", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>>>> Inset
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>>>>>.Get(JSObject, "inset");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSKeywordValue>>>>>>>.Set(JSObject, "inset", value);
    }
}

#nullable disable