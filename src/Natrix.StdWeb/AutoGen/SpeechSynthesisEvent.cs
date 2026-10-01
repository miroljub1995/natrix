// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechSynthesisEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<SpeechSynthesisEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechSynthesisEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpeechSynthesisEvent global::Natrix.JSCore.IJSObjectProxy<SpeechSynthesisEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SpeechSynthesisEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SpeechSynthesisEvent New(string type, global::Natrix.StdWeb.SpeechSynthesisEventInit eventInitDict)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = eventInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SpeechSynthesisEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.SpeechSynthesisEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SpeechSynthesisUtterance Utterance
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SpeechSynthesisUtterance>.Get(JSObject, "utterance");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CharIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "charIndex");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CharLength
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "charLength");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float ElapsedTime
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "elapsedTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }
}

#nullable disable