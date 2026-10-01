// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechRecognition: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<SpeechRecognition>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechRecognition(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpeechRecognition global::Natrix.JSCore.IJSObjectProxy<SpeechRecognition>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SpeechRecognition>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SpeechRecognition New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SpeechRecognition");
        return new global::Natrix.StdWeb.SpeechRecognition(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SpeechGrammarList Grammars
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SpeechGrammarList>.Get(JSObject, "grammars");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SpeechGrammarList>.Set(JSObject, "grammars", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Lang
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "lang");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "lang", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Continuous
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "continuous");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "continuous", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool InterimResults
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "interimResults");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "interimResults", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool UnspokenPunctuation
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "unspokenPunctuation");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "unspokenPunctuation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxAlternatives
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "maxAlternatives");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "maxAlternatives", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ProcessLocally
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "processLocally");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "processLocally", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.ObservableArray<global::Natrix.StdWeb.SpeechRecognitionPhrase, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SpeechRecognitionPhrase>> Phrases
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.ObservableArray<global::Natrix.StdWeb.SpeechRecognitionPhrase, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SpeechRecognitionPhrase>>>.Get(JSObject, "phrases");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.ObservableArray<global::Natrix.StdWeb.SpeechRecognitionPhrase, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SpeechRecognitionPhrase>>>.Set(JSObject, "phrases", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Start()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "start", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Start(global::Natrix.StdWeb.MediaStreamTrack audioTrack)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = audioTrack.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "start", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Stop()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "stop", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Abort()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "abort", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.AvailabilityStatus, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AvailabilityStatus>> Available(global::Natrix.StdWeb.SpeechRecognitionOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SpeechRecognition"), "available", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SpeechRecognition"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.AvailabilityStatus, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AvailabilityStatus>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.JSCore.Generics.Promise<bool, global::Natrix.JSCore.Generics.BooleanAccessor> Install(global::Natrix.StdWeb.SpeechRecognitionOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SpeechRecognition"), "install", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SpeechRecognition"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onaudiostart
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onaudiostart");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onaudiostart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onsoundstart
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onsoundstart");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onsoundstart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onspeechstart
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onspeechstart");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onspeechstart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onspeechend
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onspeechend");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onspeechend", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onsoundend
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onsoundend");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onsoundend", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onaudioend
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onaudioend");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onaudioend", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onresult
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onresult");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onresult", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onnomatch
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onnomatch");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onnomatch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onerror
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onerror");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onerror", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onstart
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onstart");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onstart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onend
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onend");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onend", value);
    }
}

#nullable disable