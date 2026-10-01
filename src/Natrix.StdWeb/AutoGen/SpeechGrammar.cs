// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechGrammar: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SpeechGrammar>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechGrammar(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpeechGrammar global::Natrix.JSCore.IJSObjectProxy<SpeechGrammar>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SpeechGrammar>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "src");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "src", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Weight
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "weight");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "weight", value);
    }
}

#nullable disable