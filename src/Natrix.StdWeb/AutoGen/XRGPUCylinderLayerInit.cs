// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRGPUCylinderLayerInit: global::Natrix.StdWeb.XRGPULayerInit, global::Natrix.JSCore.IJSObjectProxy<XRGPUCylinderLayerInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUCylinderLayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRGPUCylinderLayerInit global::Natrix.JSCore.IJSObjectProxy<XRGPUCylinderLayerInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUCylinderLayerInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRigidTransform? Transform
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>.Get(JSObject, "transform");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>.Set(JSObject, "transform", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Radius
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "radius");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "radius", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float CentralAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "centralAngle");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "centralAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float AspectRatio
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "aspectRatio");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "aspectRatio", value);
    }
}

#nullable disable