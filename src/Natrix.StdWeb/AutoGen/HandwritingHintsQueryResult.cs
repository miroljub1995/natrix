// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HandwritingHintsQueryResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HandwritingHintsQueryResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingHintsQueryResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HandwritingHintsQueryResult global::Natrix.JSCore.IJSObjectProxy<HandwritingHintsQueryResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingHintsQueryResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingRecognitionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingRecognitionType>> RecognitionType
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingRecognitionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingRecognitionType>>>.Get(JSObject, "recognitionType");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingRecognitionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingRecognitionType>>>.Set(JSObject, "recognitionType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingInputType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingInputType>> InputType
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingInputType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingInputType>>>.Get(JSObject, "inputType");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingInputType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingInputType>>>.Set(JSObject, "inputType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TextContext
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "textContext");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "textContext", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Alternatives
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "alternatives");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "alternatives", value);
    }
}

#nullable disable