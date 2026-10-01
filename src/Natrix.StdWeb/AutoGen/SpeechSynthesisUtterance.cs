// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechSynthesisUtterance: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<SpeechSynthesisUtterance>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechSynthesisUtterance(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpeechSynthesisUtterance global::Natrix.JSCore.IJSObjectProxy<SpeechSynthesisUtterance>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SpeechSynthesisUtterance>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SpeechSynthesisUtterance New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SpeechSynthesisUtterance");
        return new global::Natrix.StdWeb.SpeechSynthesisUtterance(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SpeechSynthesisUtterance New(string text)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = text;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SpeechSynthesisUtterance", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.SpeechSynthesisUtterance(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Text
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "text");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "text", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Lang
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "lang");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "lang", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SpeechSynthesisVoice? Voice
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.SpeechSynthesisVoice>.Get(JSObject, "voice");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.SpeechSynthesisVoice>.Set(JSObject, "voice", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Volume
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "volume");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "volume", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Rate
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "rate");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "rate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Pitch
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "pitch");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "pitch", value);
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

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onerror
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onerror");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onerror", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onpause
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onpause");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onpause", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onresume
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onresume");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onresume", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onmark
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onmark");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onmark", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onboundary
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onboundary");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onboundary", value);
    }
}

#nullable disable