// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticationExtensionsClientOutputsJSON: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsClientOutputsJSON>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsClientOutputsJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticationExtensionsClientOutputsJSON global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsClientOutputsJSON>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsClientOutputsJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
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
    public global::Natrix.StdWeb.AuthenticationExtensionsPRFOutputsJSON Prf
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsPRFOutputsJSON>.Get(JSObject, "prf");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsPRFOutputsJSON>.Set(JSObject, "prf", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobOutputsJSON LargeBlob
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobOutputsJSON>.Get(JSObject, "largeBlob");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsLargeBlobOutputsJSON>.Set(JSObject, "largeBlob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RemoteClientDataJSON
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "remoteClientDataJSON");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "remoteClientDataJSON", value);
    }
}

#nullable disable