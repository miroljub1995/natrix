// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCPeerConnectionIceEventInit: global::Natrix.StdWeb.EventInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCPeerConnectionIceEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCPeerConnectionIceEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceCandidate? Candidate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceCandidate?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "candidate");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCIceCandidate?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "candidate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Url
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "url");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "url", value);
    }
}

#nullable disable