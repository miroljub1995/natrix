// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLModelElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLModelElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLModelElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLModelElement global::Natrix.JSCore.IJSObjectProxy<HTMLModelElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLModelElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.HTMLModelElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLModelElement>> Ready
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.HTMLModelElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLModelElement>>>.Get(JSObject, "ready");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly BoundingBoxCenter
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Get(JSObject, "boundingBoxCenter");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly BoundingBoxExtents
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Get(JSObject, "boundingBoxExtents");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMMatrixReadOnly EntityTransform
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMMatrixReadOnly>.Get(JSObject, "entityTransform");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMMatrixReadOnly>.Set(JSObject, "entityTransform", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EnvironmentMap
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "environmentMap");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "environmentMap", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise EnvironmentMapReady
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(JSObject, "environmentMapReady");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string StageMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "stageMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "stageMode", value);
    }
}

#nullable disable