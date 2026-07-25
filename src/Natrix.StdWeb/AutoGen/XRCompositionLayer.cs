// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRCompositionLayer: global::Natrix.StdWeb.XRLayer
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRCompositionLayer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRLayerLayout Layout
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRLayerLayout, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "layout");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BlendTextureSourceAlpha
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "blendTextureSourceAlpha");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "blendTextureSourceAlpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ForceMonoPresentation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "forceMonoPresentation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "forceMonoPresentation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Opacity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "opacity");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "opacity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MipLevels
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mipLevels");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRLayerQuality Quality
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRLayerQuality, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "quality");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XRLayerQuality, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "quality", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool NeedsRedraw
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "needsRedraw");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Destroy()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "destroy", JSObject);
    }
}

#nullable disable