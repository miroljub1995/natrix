// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelCreateCoreOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LanguageModelCreateCoreOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelCreateCoreOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LanguageModelCreateCoreOptions global::Natrix.JSCore.IJSObjectProxy<LanguageModelCreateCoreOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelCreateCoreOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TopK
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "topK");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "topK", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Temperature
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "temperature");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "temperature", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.LanguageModelSamplingMode SamplingMode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.LanguageModelSamplingMode>.Get(JSObject, "samplingMode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.LanguageModelSamplingMode>.Set(JSObject, "samplingMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelExpected, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelExpected>> ExpectedInputs
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelExpected, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelExpected>>>.Get(JSObject, "expectedInputs");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelExpected, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelExpected>>>.Set(JSObject, "expectedInputs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelExpected, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelExpected>> ExpectedOutputs
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelExpected, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelExpected>>>.Get(JSObject, "expectedOutputs");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelExpected, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelExpected>>>.Set(JSObject, "expectedOutputs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelToolDeclaration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelToolDeclaration>> Tools
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelToolDeclaration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelToolDeclaration>>>.Get(JSObject, "tools");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelToolDeclaration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LanguageModelToolDeclaration>>>.Set(JSObject, "tools", value);
    }
}

#nullable disable