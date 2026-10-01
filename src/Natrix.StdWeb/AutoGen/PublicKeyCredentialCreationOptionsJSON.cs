// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PublicKeyCredentialCreationOptionsJSON: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PublicKeyCredentialCreationOptionsJSON>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PublicKeyCredentialCreationOptionsJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PublicKeyCredentialCreationOptionsJSON global::Natrix.JSCore.IJSObjectProxy<PublicKeyCredentialCreationOptionsJSON>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PublicKeyCredentialCreationOptionsJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PublicKeyCredentialRpEntity Rp
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialRpEntity>.Get(JSObject, "rp");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialRpEntity>.Set(JSObject, "rp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PublicKeyCredentialUserEntityJSON User
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialUserEntityJSON>.Get(JSObject, "user");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialUserEntityJSON>.Set(JSObject, "user", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Challenge
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "challenge");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "challenge", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PublicKeyCredentialParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialParameters>> PubKeyCredParams
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PublicKeyCredentialParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialParameters>>>.Get(JSObject, "pubKeyCredParams");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PublicKeyCredentialParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialParameters>>>.Set(JSObject, "pubKeyCredParams", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Timeout
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "timeout");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "timeout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON>> ExcludeCredentials
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON>>>.Get(JSObject, "excludeCredentials");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON>>>.Set(JSObject, "excludeCredentials", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticatorSelectionCriteria AuthenticatorSelection
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticatorSelectionCriteria>.Get(JSObject, "authenticatorSelection");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticatorSelectionCriteria>.Set(JSObject, "authenticatorSelection", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Hints
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "hints");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "hints", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Attestation
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "attestation");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "attestation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> AttestationFormats
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "attestationFormats");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "attestationFormats", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsClientInputsJSON Extensions
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsClientInputsJSON>.Get(JSObject, "extensions");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsClientInputsJSON>.Set(JSObject, "extensions", value);
    }
}

#nullable disable