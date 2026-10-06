// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelToolCallInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LanguageModelToolCallInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelToolCallInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LanguageModelToolCallInit global::Natrix.JSCore.IJSObjectProxy<LanguageModelToolCallInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelToolCallInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string CallId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "callId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "callId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Arguments
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "arguments");
        set => global::Natrix.JSCore.Generics.JSObjectAccessor.Set(JSObject, "arguments", value);
    }
}

#nullable disable