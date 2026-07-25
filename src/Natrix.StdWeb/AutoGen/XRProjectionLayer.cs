// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRProjectionLayer: global::Natrix.StdWeb.XRCompositionLayer
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRProjectionLayer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TextureWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "textureWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TextureHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "textureHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TextureArrayLength
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "textureArrayLength");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreDepthValues
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ignoreDepthValues");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? FixedFoveation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "fixedFoveation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "fixedFoveation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRigidTransform? DeltaPose
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRRigidTransform?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "deltaPose");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XRRigidTransform?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "deltaPose", value);
    }
}

#nullable disable