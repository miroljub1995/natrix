// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IntersectionObserverInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IntersectionObserverInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntersectionObserverInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IntersectionObserverInit global::Natrix.JSCore.IJSObjectProxy<IntersectionObserverInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntersectionObserverInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>>? Root
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>>>.Get(JSObject, "root");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>>>.Set(JSObject, "root", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RootMargin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "rootMargin");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "rootMargin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ScrollMargin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "scrollMargin");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "scrollMargin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>> Threshold
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>>>.Get(JSObject, "threshold");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>>>.Set(JSObject, "threshold", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Delay
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "delay");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "delay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TrackVisibility
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "trackVisibility");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "trackVisibility", value);
    }
}

#nullable disable