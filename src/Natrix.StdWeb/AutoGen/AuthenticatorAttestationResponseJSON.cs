// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticatorAttestationResponseJSON: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticatorAttestationResponseJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticatorAttestationResponseJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string ClientDataJSON
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clientDataJSON");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clientDataJSON", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string AuthenticatorData
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "authenticatorData");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "authenticatorData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor> Transports
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transports");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transports", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PublicKey
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "publicKey");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "publicKey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required int PublicKeyAlgorithm
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "publicKeyAlgorithm");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "publicKeyAlgorithm", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string AttestationObject
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "attestationObject");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "attestationObject", value);
    }
}

#nullable disable