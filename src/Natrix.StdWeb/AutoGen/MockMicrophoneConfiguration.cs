// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MockMicrophoneConfiguration: global::Natrix.StdWeb.MockCaptureDeviceConfiguration, global::Natrix.JSCore.IJSObjectProxy<MockMicrophoneConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MockMicrophoneConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MockMicrophoneConfiguration global::Natrix.JSCore.IJSObjectProxy<MockMicrophoneConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MockMicrophoneConfiguration(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DefaultSampleRate
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "defaultSampleRate");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "defaultSampleRate", value);
    }
}

#nullable disable