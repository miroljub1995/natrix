// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRGPUEquirectLayerInit: global::Natrix.StdWeb.XRGPULayerInit, global::Natrix.JSCore.IJSObjectProxy<XRGPUEquirectLayerInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUEquirectLayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRGPUEquirectLayerInit global::Natrix.JSCore.IJSObjectProxy<XRGPUEquirectLayerInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUEquirectLayerInit(): base()
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
    public float CentralHorizontalAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "centralHorizontalAngle");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "centralHorizontalAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float UpperVerticalAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "upperVerticalAngle");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "upperVerticalAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float LowerVerticalAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "lowerVerticalAngle");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "lowerVerticalAngle", value);
    }
}

#nullable disable