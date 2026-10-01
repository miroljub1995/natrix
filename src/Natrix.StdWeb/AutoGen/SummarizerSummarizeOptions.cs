// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SummarizerSummarizeOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SummarizerSummarizeOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SummarizerSummarizeOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SummarizerSummarizeOptions global::Natrix.JSCore.IJSObjectProxy<SummarizerSummarizeOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SummarizerSummarizeOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AbortSignal Signal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Get(JSObject, "signal");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Set(JSObject, "signal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Context
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "context");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "context", value);
    }
}

#nullable disable