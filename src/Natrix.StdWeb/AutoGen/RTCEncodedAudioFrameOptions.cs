// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCEncodedAudioFrameOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCEncodedAudioFrameOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCEncodedAudioFrameOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCEncodedAudioFrameOptions global::Natrix.JSCore.IJSObjectProxy<RTCEncodedAudioFrameOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCEncodedAudioFrameOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCEncodedAudioFrameMetadata Metadata
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCEncodedAudioFrameMetadata, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedAudioFrameMetadata>>(JSObject, "metadata");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCEncodedAudioFrameMetadata, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedAudioFrameMetadata>>(JSObject, "metadata", value);
    }
}

#nullable disable