// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticationExtensionsClientOutputs: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsClientOutputs(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsClientOutputs(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Appid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "appid");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "appid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AppidExclude
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "appidExclude");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "appidExclude", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CredentialPropertiesOutput CredProps
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CredentialPropertiesOutput, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "credProps");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CredentialPropertiesOutput, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "credProps", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsPRFOutputs Prf
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AuthenticationExtensionsPRFOutputs, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "prf");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AuthenticationExtensionsPRFOutputs, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "prf", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobOutputs LargeBlob
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobOutputs, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "largeBlob");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobOutputs, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "largeBlob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RemoteClientDataJSON
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "remoteClientDataJSON");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "remoteClientDataJSON", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsPaymentOutputs Payment
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AuthenticationExtensionsPaymentOutputs, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "payment");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AuthenticationExtensionsPaymentOutputs, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "payment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CredBlob
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "credBlob");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "credBlob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer GetCredBlob
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "getCredBlob");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "getCredBlob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HmacCreateSecret
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hmacCreateSecret");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hmacCreateSecret", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HMACGetSecretOutput HmacGetSecret
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.HMACGetSecretOutput, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hmacGetSecret");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.HMACGetSecretOutput, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hmacGetSecret", value);
    }
}

#nullable disable