// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRInputSourceEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<XRInputSourceEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRInputSourceEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRInputSourceEventInit global::Natrix.JSCore.IJSObjectProxy<XRInputSourceEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRInputSourceEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.XRFrame Frame
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRFrame>>(JSObject, "frame");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XRFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRFrame>>(JSObject, "frame", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.XRInputSource InputSource
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRInputSource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRInputSource>>(JSObject, "inputSource");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XRInputSource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRInputSource>>(JSObject, "inputSource", value);
    }
}

#nullable disable