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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingRecognitionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingRecognitionType>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingRecognitionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingRecognitionType>>>>(JSObject, "recognitionType");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingRecognitionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingRecognitionType>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingRecognitionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingRecognitionType>>>>(JSObject, "recognitionType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingInputType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingInputType>> InputType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingInputType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingInputType>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingInputType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingInputType>>>>(JSObject, "inputType");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingInputType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingInputType>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingInputType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HandwritingInputType>>>>(JSObject, "inputType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TextContext
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "textContext");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "textContext", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Alternatives
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "alternatives");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "alternatives", value);
    }
}

#nullable disable