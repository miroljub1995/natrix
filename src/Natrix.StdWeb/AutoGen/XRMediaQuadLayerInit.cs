// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRMediaQuadLayerInit: global::Natrix.StdWeb.XRMediaLayerInit, global::Natrix.JSCore.IJSObjectProxy<XRMediaQuadLayerInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRMediaQuadLayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRMediaQuadLayerInit global::Natrix.JSCore.IJSObjectProxy<XRMediaQuadLayerInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRMediaQuadLayerInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRigidTransform? Transform
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>.Get(JSObject, "transform");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>.Set(JSObject, "transform", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? Width
    {
        get => global::Natrix.JSCore.Generics.NullableSingleAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.NullableSingleAccessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? Height
    {
        get => global::Natrix.JSCore.Generics.NullableSingleAccessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.NullableSingleAccessor.Set(JSObject, "height", value);
    }
}

#nullable disable