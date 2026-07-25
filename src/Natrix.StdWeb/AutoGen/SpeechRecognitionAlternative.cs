// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechRecognitionAlternative: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechRecognitionAlternative(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Transcript
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transcript");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Confidence
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "confidence");
    }
}

#nullable disable