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
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "textureWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TextureHeight
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "textureHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TextureArrayLength
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "textureArrayLength");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreDepthValues
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ignoreDepthValues");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? FixedFoveation
    {
        get => global::Natrix.JSCore.Generics.NullableSingleAccessor.Get(JSObject, "fixedFoveation");
        set => global::Natrix.JSCore.Generics.NullableSingleAccessor.Set(JSObject, "fixedFoveation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRigidTransform? DeltaPose
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>.Get(JSObject, "deltaPose");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>.Set(JSObject, "deltaPose", value);
    }
}

#nullable disable