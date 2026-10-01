// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechRecognitionPhrase: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SpeechRecognitionPhrase>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechRecognitionPhrase(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpeechRecognitionPhrase global::Natrix.JSCore.IJSObjectProxy<SpeechRecognitionPhrase>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SpeechRecognitionPhrase>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SpeechRecognitionPhrase New(string phrase)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = phrase;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SpeechRecognitionPhrase", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.SpeechRecognitionPhrase(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SpeechRecognitionPhrase New(string phrase, float boost)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = phrase;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        double ___marshalledValue_5;
        ___marshalledValue_5 = Convert.ToDouble(boost);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SpeechRecognitionPhrase", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.SpeechRecognitionPhrase(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Phrase
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "phrase");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Boost
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "boost");
    }
}

#nullable disable