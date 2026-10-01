// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLMarqueeElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLMarqueeElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLMarqueeElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLMarqueeElement global::Natrix.JSCore.IJSObjectProxy<HTMLMarqueeElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLMarqueeElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLMarqueeElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLMarqueeElement");
        return new global::Natrix.StdWeb.HTMLMarqueeElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Behavior
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "behavior");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "behavior", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string BgColor
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "bgColor");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "bgColor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Direction
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "direction");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "direction", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Height
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Hspace
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "hspace");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "hspace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Loop
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "loop");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "loop", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ScrollAmount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "scrollAmount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "scrollAmount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ScrollDelay
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "scrollDelay");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "scrollDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TrueSpeed
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "trueSpeed");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "trueSpeed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Vspace
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "vspace");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "vspace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Width
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Start()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "start", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Stop()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "stop", JSObject);
    }
}

#nullable disable