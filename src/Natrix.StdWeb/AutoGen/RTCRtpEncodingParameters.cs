// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCRtpEncodingParameters: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCRtpEncodingParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpEncodingParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCRtpEncodingParameters global::Natrix.JSCore.IJSObjectProxy<RTCRtpEncodingParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpEncodingParameters(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCPriorityType Priority
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCPriorityType>.Get(JSObject, "priority");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCPriorityType>.Set(JSObject, "priority", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCPriorityType NetworkPriority
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCPriorityType>.Get(JSObject, "networkPriority");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCPriorityType>.Set(JSObject, "networkPriority", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ScalabilityMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "scalabilityMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "scalabilityMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Active
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "active");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "active", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCRtpCodec Codec
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpCodec>.Get(JSObject, "codec");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpCodec>.Set(JSObject, "codec", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxBitrate
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "maxBitrate");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "maxBitrate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MaxFramerate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "maxFramerate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "maxFramerate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScaleResolutionDownBy
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "scaleResolutionDownBy");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "scaleResolutionDownBy", value);
    }
}

#nullable disable