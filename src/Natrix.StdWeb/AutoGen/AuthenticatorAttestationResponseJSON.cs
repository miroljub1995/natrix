// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticatorAttestationResponseJSON: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticatorAttestationResponseJSON>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticatorAttestationResponseJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticatorAttestationResponseJSON global::Natrix.JSCore.IJSObjectProxy<AuthenticatorAttestationResponseJSON>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticatorAttestationResponseJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
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
    public required global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Transports
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "transports");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "transports", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PublicKey
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "publicKey");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "publicKey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required int PublicKeyAlgorithm
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "publicKeyAlgorithm");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "publicKeyAlgorithm", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string AttestationObject
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "attestationObject");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "attestationObject", value);
    }
}

#nullable disable