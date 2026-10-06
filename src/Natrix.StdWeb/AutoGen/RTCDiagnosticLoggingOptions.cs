// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCDiagnosticLoggingOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCDiagnosticLoggingOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCDiagnosticLoggingOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCDiagnosticLoggingOptions global::Natrix.JSCore.IJSObjectProxy<RTCDiagnosticLoggingOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCDiagnosticLoggingOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Record<string, global::Natrix.JSCore.Generics.StringAccessor> Metadata
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "metadata");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "metadata", value);
    }
}

#nullable disable