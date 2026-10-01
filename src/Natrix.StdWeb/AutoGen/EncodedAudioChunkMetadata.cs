// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EncodedAudioChunkMetadata: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<EncodedAudioChunkMetadata>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EncodedAudioChunkMetadata(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EncodedAudioChunkMetadata global::Natrix.JSCore.IJSObjectProxy<EncodedAudioChunkMetadata>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EncodedAudioChunkMetadata(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioDecoderConfig DecoderConfig
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioDecoderConfig>.Get(JSObject, "decoderConfig");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioDecoderConfig>.Set(JSObject, "decoderConfig", value);
    }
}

#nullable disable