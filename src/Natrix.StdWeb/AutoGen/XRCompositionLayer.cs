// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRCompositionLayer: global::Natrix.StdWeb.XRLayer, global::Natrix.JSCore.IJSObjectProxy<XRCompositionLayer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRCompositionLayer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRCompositionLayer global::Natrix.JSCore.IJSObjectProxy<XRCompositionLayer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRCompositionLayer>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRLayerLayout Layout
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRLayerLayout, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRLayerLayout>>(JSObject, "layout");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BlendTextureSourceAlpha
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "blendTextureSourceAlpha");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "blendTextureSourceAlpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ForceMonoPresentation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "forceMonoPresentation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "forceMonoPresentation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Opacity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "opacity");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "opacity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MipLevels
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "mipLevels");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRLayerQuality Quality
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRLayerQuality, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRLayerQuality>>(JSObject, "quality");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XRLayerQuality, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRLayerQuality>>(JSObject, "quality", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool NeedsRedraw
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "needsRedraw");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Destroy()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "destroy", JSObject);
    }
}

#nullable disable