// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechSynthesisEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<SpeechSynthesisEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechSynthesisEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpeechSynthesisEventInit global::Natrix.JSCore.IJSObjectProxy<SpeechSynthesisEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechSynthesisEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.SpeechSynthesisUtterance Utterance
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SpeechSynthesisUtterance>.Get(JSObject, "utterance");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SpeechSynthesisUtterance>.Set(JSObject, "utterance", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CharIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "charIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "charIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CharLength
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "charLength");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "charLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float ElapsedTime
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "elapsedTime");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "elapsedTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }
}

#nullable disable