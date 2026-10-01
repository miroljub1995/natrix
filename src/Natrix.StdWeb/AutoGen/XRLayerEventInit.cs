// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRLayerEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<XRLayerEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRLayerEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRLayerEventInit global::Natrix.JSCore.IJSObjectProxy<XRLayerEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRLayerEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.XRLayer Layer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRLayer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRLayer>>(JSObject, "layer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XRLayer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRLayer>>(JSObject, "layer", value);
    }
}

#nullable disable