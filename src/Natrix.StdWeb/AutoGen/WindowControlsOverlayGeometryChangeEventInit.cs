// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WindowControlsOverlayGeometryChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<WindowControlsOverlayGeometryChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WindowControlsOverlayGeometryChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WindowControlsOverlayGeometryChangeEventInit global::Natrix.JSCore.IJSObjectProxy<WindowControlsOverlayGeometryChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WindowControlsOverlayGeometryChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.DOMRect TitlebarAreaRect
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMRect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRect>>(JSObject, "titlebarAreaRect");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DOMRect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRect>>(JSObject, "titlebarAreaRect", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Visible
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "visible");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "visible", value);
    }
}

#nullable disable