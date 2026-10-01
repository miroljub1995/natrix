// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IntersectionObserverEntryInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IntersectionObserverEntryInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntersectionObserverEntryInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IntersectionObserverEntryInit global::Natrix.JSCore.IJSObjectProxy<IntersectionObserverEntryInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntersectionObserverEntryInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double Time
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "time");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "time", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.DOMRectInit? RootBounds
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DOMRectInit>.Get(JSObject, "rootBounds");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DOMRectInit>.Set(JSObject, "rootBounds", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.DOMRectInit BoundingClientRect
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectInit>.Get(JSObject, "boundingClientRect");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectInit>.Set(JSObject, "boundingClientRect", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.DOMRectInit IntersectionRect
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectInit>.Get(JSObject, "intersectionRect");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectInit>.Set(JSObject, "intersectionRect", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool IsIntersecting
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isIntersecting");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isIntersecting", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool IsVisible
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isVisible");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isVisible", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double IntersectionRatio
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "intersectionRatio");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "intersectionRatio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.Element Target
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "target");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>.Set(JSObject, "target", value);
    }
}

#nullable disable