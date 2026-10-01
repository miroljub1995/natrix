// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCRtpContributingSource: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCRtpContributingSource>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpContributingSource(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCRtpContributingSource global::Natrix.JSCore.IJSObjectProxy<RTCRtpContributingSource>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpContributingSource(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double Timestamp
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "timestamp");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "timestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Source
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "source");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "source", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AudioLevel
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "audioLevel");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "audioLevel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint RtpTimestamp
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "rtpTimestamp");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "rtpTimestamp", value);
    }
}

#nullable disable