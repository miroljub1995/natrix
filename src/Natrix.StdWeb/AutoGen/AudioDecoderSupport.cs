// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioDecoderSupport: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioDecoderSupport>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioDecoderSupport(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioDecoderSupport global::Natrix.JSCore.IJSObjectProxy<AudioDecoderSupport>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioDecoderSupport(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Supported
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "supported");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "supported", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioDecoderConfig Config
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioDecoderConfig>.Get(JSObject, "config");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioDecoderConfig>.Set(JSObject, "config", value);
    }
}

#nullable disable