// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLTrackElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLTrackElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLTrackElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLTrackElement global::Natrix.JSCore.IJSObjectProxy<HTMLTrackElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLTrackElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLTrackElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLTrackElement");
        return new global::Natrix.StdWeb.HTMLTrackElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Kind
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "kind");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "kind", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "src");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "src", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Srclang
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "srclang");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "srclang", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "label", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Default
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "default");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "default", value);
    }

    public const ushort NONE = 0;

    public const ushort LOADING = 1;

    public const ushort LOADED = 2;

    public const ushort ERROR = 3;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ReadyState
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "readyState");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TextTrack Track
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextTrack>.Get(JSObject, "track");
    }
}

#nullable disable