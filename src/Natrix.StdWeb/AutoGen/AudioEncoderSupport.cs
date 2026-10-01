// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioEncoderSupport: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioEncoderSupport>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioEncoderSupport(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioEncoderSupport global::Natrix.JSCore.IJSObjectProxy<AudioEncoderSupport>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioEncoderSupport(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Supported
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "supported");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "supported", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioEncoderConfig Config
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioEncoderConfig>.Get(JSObject, "config");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioEncoderConfig>.Set(JSObject, "config", value);
    }
}

#nullable disable