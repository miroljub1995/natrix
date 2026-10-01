// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PictureInPictureWindow: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<PictureInPictureWindow>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PictureInPictureWindow(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PictureInPictureWindow global::Natrix.JSCore.IJSObjectProxy<PictureInPictureWindow>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PictureInPictureWindow>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Width
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "width");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Height
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "height");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onresize
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onresize");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onresize", value);
    }
}

#nullable disable