// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRProjectionLayer: global::Natrix.StdWeb.XRCompositionLayer, global::Natrix.JSCore.IJSObjectProxy<XRProjectionLayer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRProjectionLayer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRProjectionLayer global::Natrix.JSCore.IJSObjectProxy<XRProjectionLayer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRProjectionLayer>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TextureWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "textureWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TextureHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "textureHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TextureArrayLength
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "textureArrayLength");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreDepthValues
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "ignoreDepthValues");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? FixedFoveation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.JSCore.Generics.NullableSingleAccessor>(JSObject, "fixedFoveation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float?, global::Natrix.JSCore.Generics.NullableSingleAccessor>(JSObject, "fixedFoveation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRigidTransform? DeltaPose
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRRigidTransform?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>>(JSObject, "deltaPose");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XRRigidTransform?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>>(JSObject, "deltaPose", value);
    }
}

#nullable disable