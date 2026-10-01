// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SpeechRecognitionOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SpeechRecognitionOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechRecognitionOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SpeechRecognitionOptions global::Natrix.JSCore.IJSObjectProxy<SpeechRecognitionOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SpeechRecognitionOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Langs
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "langs");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "langs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ProcessLocally
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "processLocally");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "processLocally", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SpeechRecognitionQuality Quality
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SpeechRecognitionQuality>.Get(JSObject, "quality");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SpeechRecognitionQuality>.Set(JSObject, "quality", value);
    }
}

#nullable disable