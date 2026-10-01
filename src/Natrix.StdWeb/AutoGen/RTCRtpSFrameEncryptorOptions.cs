// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCRtpSFrameEncryptorOptions: global::Natrix.StdWeb.SFrameTransformOptions, global::Natrix.JSCore.IJSObjectProxy<RTCRtpSFrameEncryptorOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpSFrameEncryptorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCRtpSFrameEncryptorOptions global::Natrix.JSCore.IJSObjectProxy<RTCRtpSFrameEncryptorOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpSFrameEncryptorOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SFrameType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SFrameType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SFrameType>>(JSObject, "type");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.SFrameType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SFrameType>>(JSObject, "type", value);
    }
}

#nullable disable