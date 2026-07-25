// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLMarqueeElement: global::Natrix.StdWeb.HTMLElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLMarqueeElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLMarqueeElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLMarqueeElement");
        return new global::Natrix.StdWeb.HTMLMarqueeElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Behavior
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "behavior");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "behavior", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string BgColor
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "bgColor");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "bgColor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Direction
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "direction");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "direction", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Height
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "height");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Hspace
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hspace");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hspace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Loop
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "loop");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "loop", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ScrollAmount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "scrollAmount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "scrollAmount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ScrollDelay
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "scrollDelay");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "scrollDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TrueSpeed
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "trueSpeed");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "trueSpeed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Vspace
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vspace");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vspace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width", value);
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