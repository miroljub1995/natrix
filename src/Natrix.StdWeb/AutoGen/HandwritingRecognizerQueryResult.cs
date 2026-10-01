// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HandwritingRecognizerQueryResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HandwritingRecognizerQueryResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingRecognizerQueryResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HandwritingRecognizerQueryResult global::Natrix.JSCore.IJSObjectProxy<HandwritingRecognizerQueryResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingRecognizerQueryResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TextAlternatives
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "textAlternatives");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "textAlternatives", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TextSegmentation
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "textSegmentation");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "textSegmentation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HandwritingHintsQueryResult Hints
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HandwritingHintsQueryResult>.Get(JSObject, "hints");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HandwritingHintsQueryResult>.Set(JSObject, "hints", value);
    }
}

#nullable disable