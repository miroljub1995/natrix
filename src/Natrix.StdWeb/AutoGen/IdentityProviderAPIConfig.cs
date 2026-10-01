// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IdentityProviderAPIConfig: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IdentityProviderAPIConfig>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdentityProviderAPIConfig(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IdentityProviderAPIConfig global::Natrix.JSCore.IJSObjectProxy<IdentityProviderAPIConfig>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdentityProviderAPIConfig(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Accounts_endpoint
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "accounts_endpoint");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "accounts_endpoint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Client_metadata_endpoint
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "client_metadata_endpoint");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "client_metadata_endpoint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Id_assertion_endpoint
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id_assertion_endpoint");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id_assertion_endpoint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Login_url
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "login_url");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "login_url", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Disconnect_endpoint
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "disconnect_endpoint");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "disconnect_endpoint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.IdentityProviderBranding Branding
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IdentityProviderBranding>.Get(JSObject, "branding");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IdentityProviderBranding>.Set(JSObject, "branding", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Supports_use_other_account
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "supports_use_other_account");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "supports_use_other_account", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Account_label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "account_label");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "account_label", value);
    }
}

#nullable disable