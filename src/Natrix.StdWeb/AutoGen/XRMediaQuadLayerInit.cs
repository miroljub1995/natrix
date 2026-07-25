// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRMediaQuadLayerInit: global::Natrix.StdWeb.XRMediaLayerInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRMediaQuadLayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRMediaQuadLayerInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRigidTransform? Transform
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRRigidTransform?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "transform");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XRRigidTransform?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "transform", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "width");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float? Height
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "height");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "height", value);
    }
}

#nullable disable