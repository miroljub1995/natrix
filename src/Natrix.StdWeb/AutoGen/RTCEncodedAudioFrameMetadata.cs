// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCEncodedAudioFrameMetadata: global::Natrix.StdWeb.RTCEncodedFrameMetadata
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCEncodedAudioFrameMetadata(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCEncodedAudioFrameMetadata(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public short SequenceNumber
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<short, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sequenceNumber");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<short, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sequenceNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AudioLevel
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "audioLevel");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "audioLevel", value);
    }
}

#nullable disable