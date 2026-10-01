// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIdentityAssertionResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCIdentityAssertionResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIdentityAssertionResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCIdentityAssertionResult global::Natrix.JSCore.IJSObjectProxy<RTCIdentityAssertionResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIdentityAssertionResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCIdentityProviderDetails Idp
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIdentityProviderDetails>.Get(JSObject, "idp");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIdentityProviderDetails>.Set(JSObject, "idp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Assertion
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "assertion");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "assertion", value);
    }
}

#nullable disable