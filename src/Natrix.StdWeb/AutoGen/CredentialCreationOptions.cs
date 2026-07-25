// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CredentialCreationOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CredentialCreationOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CredentialCreationOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CredentialMediationRequirement Mediation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CredentialMediationRequirement, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mediation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CredentialMediationRequirement, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mediation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AbortSignal Signal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AbortSignal, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "signal");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AbortSignal, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "signal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.PasswordCredentialData, global::Natrix.StdWeb.HTMLFormElement, global::Natrix.StdWeb.GenericMarshaller.Union> Password
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.PasswordCredentialData, global::Natrix.StdWeb.HTMLFormElement, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "password");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.PasswordCredentialData, global::Natrix.StdWeb.HTMLFormElement, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "password", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FederatedCredentialInit Federated
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.FederatedCredentialInit, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "federated");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.FederatedCredentialInit, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "federated", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PublicKeyCredentialCreationOptions PublicKey
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PublicKeyCredentialCreationOptions, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "publicKey");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.PublicKeyCredentialCreationOptions, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "publicKey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DigitalCredentialCreationOptions Digital
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DigitalCredentialCreationOptions, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "digital");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DigitalCredentialCreationOptions, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "digital", value);
    }
}

#nullable disable