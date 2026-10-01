// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechRecognitionEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<SpeechRecognitionEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechRecognitionEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpeechRecognitionEventInit global::Natrix.JSCore.IJSObjectProxy<SpeechRecognitionEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechRecognitionEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ResultIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "resultIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "resultIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.SpeechRecognitionResultList Results
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SpeechRecognitionResultList>.Get(JSObject, "results");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SpeechRecognitionResultList>.Set(JSObject, "results", value);
    }
}

#nullable disable