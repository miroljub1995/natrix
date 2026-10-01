// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechRecognitionAlternative: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SpeechRecognitionAlternative>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechRecognitionAlternative(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpeechRecognitionAlternative global::Natrix.JSCore.IJSObjectProxy<SpeechRecognitionAlternative>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SpeechRecognitionAlternative>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Transcript
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "transcript");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Confidence
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "confidence");
    }
}

#nullable disable