// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BrowserBoundSignature: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BrowserBoundSignature>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BrowserBoundSignature(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BrowserBoundSignature global::Natrix.JSCore.IJSObjectProxy<BrowserBoundSignature>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BrowserBoundSignature(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.ArrayBuffer Signature
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "signature");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Set(JSObject, "signature", value);
    }
}

#nullable disable