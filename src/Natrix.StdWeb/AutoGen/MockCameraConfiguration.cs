// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MockCameraConfiguration: global::Natrix.StdWeb.MockCaptureDeviceConfiguration, global::Natrix.JSCore.IJSObjectProxy<MockCameraConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MockCameraConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MockCameraConfiguration global::Natrix.JSCore.IJSObjectProxy<MockCameraConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MockCameraConfiguration(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DefaultFrameRate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "defaultFrameRate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "defaultFrameRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FacingMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "facingMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "facingMode", value);
    }
}

#nullable disable