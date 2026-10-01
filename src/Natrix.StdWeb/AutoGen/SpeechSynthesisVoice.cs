// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechSynthesisVoice: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SpeechSynthesisVoice>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechSynthesisVoice(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpeechSynthesisVoice global::Natrix.JSCore.IJSObjectProxy<SpeechSynthesisVoice>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SpeechSynthesisVoice>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string VoiceURI
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "voiceURI");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Lang
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "lang");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool LocalService
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "localService");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Default
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "default");
    }
}

#nullable disable