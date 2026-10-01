// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelMessage: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LanguageModelMessage>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelMessage(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LanguageModelMessage global::Natrix.JSCore.IJSObjectProxy<LanguageModelMessage>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelMessage(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.LanguageModelMessageRole Role
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.LanguageModelMessageRole>.Get(JSObject, "role");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.LanguageModelMessageRole>.Set(JSObject, "role", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelMessageContent>>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelMessageContent>>>> Content
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelMessageContent>>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelMessageContent>>>>>.Get(JSObject, "content");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelMessageContent>>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelMessageContent>>>>>.Set(JSObject, "content", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Prefix
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "prefix");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "prefix", value);
    }
}

#nullable disable