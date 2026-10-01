// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticationExtensionsClientInputs: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsClientInputs>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsClientInputs(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticationExtensionsClientInputs global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsClientInputs>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsClientInputs(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CredentialProtectionPolicy
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "credentialProtectionPolicy");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "credentialProtectionPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool EnforceCredentialProtectionPolicy
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "enforceCredentialProtectionPolicy");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "enforceCredentialProtectionPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer CredBlob
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "credBlob");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Set(JSObject, "credBlob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool GetCredBlob
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "getCredBlob");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "getCredBlob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool MinPinLength
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "minPinLength");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "minPinLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PinComplexityPolicy
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "pinComplexityPolicy");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "pinComplexityPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HmacCreateSecret
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hmacCreateSecret");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "hmacCreateSecret", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HMACGetSecretInput HmacGetSecret
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HMACGetSecretInput>.Get(JSObject, "hmacGetSecret");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HMACGetSecretInput>.Set(JSObject, "hmacGetSecret", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsPaymentInputs Payment
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsPaymentInputs>.Get(JSObject, "payment");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsPaymentInputs>.Set(JSObject, "payment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Appid
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "appid");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "appid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AppidExclude
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "appidExclude");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "appidExclude", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CredProps
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "credProps");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "credProps", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsPRFInputs Prf
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsPRFInputs>.Get(JSObject, "prf");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsPRFInputs>.Set(JSObject, "prf", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobInputs LargeBlob
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobInputs>.Get(JSObject, "largeBlob");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobInputs>.Set(JSObject, "largeBlob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RemoteClientDataJSON
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "remoteClientDataJSON");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "remoteClientDataJSON", value);
    }
}

#nullable disable