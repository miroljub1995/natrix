// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRCubeLayerInit: global::Natrix.StdWeb.XRLayerInit, global::Natrix.JSCore.IJSObjectProxy<XRCubeLayerInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRCubeLayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRCubeLayerInit global::Natrix.JSCore.IJSObjectProxy<XRCubeLayerInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRCubeLayerInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly? Orientation
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Get(JSObject, "orientation");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Set(JSObject, "orientation", value);
    }
}

#nullable disable