// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelToolErrorInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LanguageModelToolErrorInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelToolErrorInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LanguageModelToolErrorInit global::Natrix.JSCore.IJSObjectProxy<LanguageModelToolErrorInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelToolErrorInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
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
    public required string ErrorMessage
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "errorMessage");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "errorMessage", value);
    }
}

#nullable disable