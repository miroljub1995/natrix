// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRGPUCubeLayerInit: global::Natrix.StdWeb.XRGPULayerInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUCubeLayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUCubeLayerInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly? Orientation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMPointReadOnly?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "orientation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DOMPointReadOnly?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "orientation", value);
    }
}

#nullable disable