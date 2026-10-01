// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HandwritingHints: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HandwritingHints>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingHints(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HandwritingHints global::Natrix.JSCore.IJSObjectProxy<HandwritingHints>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingHints(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RecognitionType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "recognitionType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "recognitionType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string InputType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "inputType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "inputType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TextContext
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "textContext");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "textContext", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Alternatives
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "alternatives");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "alternatives", value);
    }
}

#nullable disable