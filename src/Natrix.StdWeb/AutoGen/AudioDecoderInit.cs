// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioDecoderInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioDecoderInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioDecoderInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioDecoderInit global::Natrix.JSCore.IJSObjectProxy<AudioDecoderInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioDecoderInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.AudioDataOutputCallback Output
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioDataOutputCallback>.Get(JSObject, "output");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioDataOutputCallback>.Set(JSObject, "output", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.WebCodecsErrorCallback Error
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebCodecsErrorCallback>.Get(JSObject, "error");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebCodecsErrorCallback>.Set(JSObject, "error", value);
    }
}

#nullable disable