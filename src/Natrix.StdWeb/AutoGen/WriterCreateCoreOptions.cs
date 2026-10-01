// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WriterCreateCoreOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WriterCreateCoreOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WriterCreateCoreOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WriterCreateCoreOptions global::Natrix.JSCore.IJSObjectProxy<WriterCreateCoreOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WriterCreateCoreOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WriterTone Tone
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WriterTone>.Get(JSObject, "tone");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WriterTone>.Set(JSObject, "tone", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WriterFormat Format
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WriterFormat>.Get(JSObject, "format");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WriterFormat>.Set(JSObject, "format", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WriterLength Length
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WriterLength>.Get(JSObject, "length");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WriterLength>.Set(JSObject, "length", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> ExpectedInputLanguages
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "expectedInputLanguages");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "expectedInputLanguages", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> ExpectedContextLanguages
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "expectedContextLanguages");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "expectedContextLanguages", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string OutputLanguage
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "outputLanguage");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "outputLanguage", value);
    }
}

#nullable disable