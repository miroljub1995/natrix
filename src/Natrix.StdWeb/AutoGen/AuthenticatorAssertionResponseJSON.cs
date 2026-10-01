// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticatorAssertionResponseJSON: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticatorAssertionResponseJSON>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticatorAssertionResponseJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticatorAssertionResponseJSON global::Natrix.JSCore.IJSObjectProxy<AuthenticatorAssertionResponseJSON>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticatorAssertionResponseJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string ClientDataJSON
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "clientDataJSON");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "clientDataJSON", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string AuthenticatorData
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "authenticatorData");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "authenticatorData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Signature
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "signature");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "signature", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UserHandle
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "userHandle");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "userHandle", value);
    }
}

#nullable disable