// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CredentialCreationOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CredentialCreationOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CredentialCreationOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CredentialCreationOptions global::Natrix.JSCore.IJSObjectProxy<CredentialCreationOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CredentialCreationOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CredentialMediationRequirement Mediation
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CredentialMediationRequirement>.Get(JSObject, "mediation");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CredentialMediationRequirement>.Set(JSObject, "mediation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AbortSignal Signal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Get(JSObject, "signal");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Set(JSObject, "signal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.PasswordCredentialData, global::Natrix.StdWeb.HTMLFormElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PasswordCredentialData>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLFormElement>> Password
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.PasswordCredentialData, global::Natrix.StdWeb.HTMLFormElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PasswordCredentialData>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLFormElement>>>.Get(JSObject, "password");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.PasswordCredentialData, global::Natrix.StdWeb.HTMLFormElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PasswordCredentialData>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLFormElement>>>.Set(JSObject, "password", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FederatedCredentialInit Federated
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FederatedCredentialInit>.Get(JSObject, "federated");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FederatedCredentialInit>.Set(JSObject, "federated", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DigitalCredentialCreationOptions Digital
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DigitalCredentialCreationOptions>.Get(JSObject, "digital");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DigitalCredentialCreationOptions>.Set(JSObject, "digital", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PublicKeyCredentialCreationOptions PublicKey
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialCreationOptions>.Get(JSObject, "publicKey");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialCreationOptions>.Set(JSObject, "publicKey", value);
    }
}

#nullable disable