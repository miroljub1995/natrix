// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticationExtensionsClientOutputs: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsClientOutputs>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsClientOutputs(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticationExtensionsClientOutputs global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsClientOutputs>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsClientOutputs(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CredBlob
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "credBlob");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "credBlob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer GetCredBlob
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "getCredBlob");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Set(JSObject, "getCredBlob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HmacCreateSecret
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hmacCreateSecret");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "hmacCreateSecret", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HMACGetSecretOutput HmacGetSecret
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HMACGetSecretOutput>.Get(JSObject, "hmacGetSecret");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HMACGetSecretOutput>.Set(JSObject, "hmacGetSecret", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsPaymentOutputs Payment
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsPaymentOutputs>.Get(JSObject, "payment");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsPaymentOutputs>.Set(JSObject, "payment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Appid
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "appid");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "appid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AppidExclude
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "appidExclude");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "appidExclude", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CredentialPropertiesOutput CredProps
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CredentialPropertiesOutput>.Get(JSObject, "credProps");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CredentialPropertiesOutput>.Set(JSObject, "credProps", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsPRFOutputs Prf
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsPRFOutputs>.Get(JSObject, "prf");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsPRFOutputs>.Set(JSObject, "prf", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobOutputs LargeBlob
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobOutputs>.Get(JSObject, "largeBlob");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobOutputs>.Set(JSObject, "largeBlob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RemoteClientDataJSON
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "remoteClientDataJSON");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "remoteClientDataJSON", value);
    }
}

#nullable disable