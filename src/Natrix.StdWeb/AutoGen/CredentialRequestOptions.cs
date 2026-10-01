// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CredentialRequestOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CredentialRequestOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CredentialRequestOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CredentialRequestOptions global::Natrix.JSCore.IJSObjectProxy<CredentialRequestOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CredentialRequestOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CredentialMediationRequirement Mediation
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CredentialMediationRequirement>.Get(JSObject, "mediation");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CredentialMediationRequirement>.Set(JSObject, "mediation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UiMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "uiMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "uiMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AbortSignal Signal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Get(JSObject, "signal");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Set(JSObject, "signal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Password
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "password");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "password", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FederatedCredentialRequestOptions Federated
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FederatedCredentialRequestOptions>.Get(JSObject, "federated");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FederatedCredentialRequestOptions>.Set(JSObject, "federated", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DigitalCredentialRequestOptions Digital
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DigitalCredentialRequestOptions>.Get(JSObject, "digital");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DigitalCredentialRequestOptions>.Set(JSObject, "digital", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.IdentityCredentialRequestOptions Identity
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IdentityCredentialRequestOptions>.Get(JSObject, "identity");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IdentityCredentialRequestOptions>.Set(JSObject, "identity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.OTPCredentialRequestOptions Otp
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OTPCredentialRequestOptions>.Get(JSObject, "otp");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OTPCredentialRequestOptions>.Set(JSObject, "otp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PublicKeyCredentialRequestOptions PublicKey
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialRequestOptions>.Get(JSObject, "publicKey");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialRequestOptions>.Set(JSObject, "publicKey", value);
    }
}

#nullable disable