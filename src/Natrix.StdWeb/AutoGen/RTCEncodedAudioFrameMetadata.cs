// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCEncodedAudioFrameMetadata: global::Natrix.StdWeb.RTCEncodedFrameMetadata, global::Natrix.JSCore.IJSObjectProxy<RTCEncodedAudioFrameMetadata>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCEncodedAudioFrameMetadata(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCEncodedAudioFrameMetadata global::Natrix.JSCore.IJSObjectProxy<RTCEncodedAudioFrameMetadata>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCEncodedAudioFrameMetadata(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public short SequenceNumber
    {
        get => global::Natrix.JSCore.Generics.Int16Accessor.Get(JSObject, "sequenceNumber");
        set => global::Natrix.JSCore.Generics.Int16Accessor.Set(JSObject, "sequenceNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AudioLevel
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "audioLevel");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "audioLevel", value);
    }
}

#nullable disable