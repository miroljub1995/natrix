// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageDetectionResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LanguageDetectionResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageDetectionResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LanguageDetectionResult global::Natrix.JSCore.IJSObjectProxy<LanguageDetectionResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageDetectionResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DetectedLanguage
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "detectedLanguage");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "detectedLanguage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Confidence
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "confidence");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "confidence", value);
    }
}

#nullable disable