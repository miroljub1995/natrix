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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.HTMLModelElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLModelElement>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.HTMLModelElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLModelElement>>>>(JSObject, "ready");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly BoundingBoxCenter
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMPointReadOnly, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>>(JSObject, "boundingBoxCenter");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly BoundingBoxExtents
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMPointReadOnly, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>>(JSObject, "boundingBoxExtents");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMMatrixReadOnly EntityTransform
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMMatrixReadOnly, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMMatrixReadOnly>>(JSObject, "entityTransform");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DOMMatrixReadOnly, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMMatrixReadOnly>>(JSObject, "entityTransform", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EnvironmentMap
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "environmentMap");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "environmentMap", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise EnvironmentMapReady
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Promise, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>>(JSObject, "environmentMapReady");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string StageMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "stageMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "stageMode", value);
    }
}

#nullable disable