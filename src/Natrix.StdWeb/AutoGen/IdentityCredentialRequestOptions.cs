// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IdentityCredentialRequestOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IdentityCredentialRequestOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdentityCredentialRequestOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IdentityCredentialRequestOptions global::Natrix.JSCore.IJSObjectProxy<IdentityCredentialRequestOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdentityCredentialRequestOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.IdentityProviderRequestOptions, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IdentityProviderRequestOptions>> Providers
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.IdentityProviderRequestOptions, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IdentityProviderRequestOptions>>>.Get(JSObject, "providers");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.IdentityProviderRequestOptions, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IdentityProviderRequestOptions>>>.Set(JSObject, "providers", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.IdentityCredentialRequestOptionsContext Context
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.IdentityCredentialRequestOptionsContext>.Get(JSObject, "context");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.IdentityCredentialRequestOptionsContext>.Set(JSObject, "context", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.IdentityCredentialRequestOptionsMode Mode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.IdentityCredentialRequestOptionsMode>.Get(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.IdentityCredentialRequestOptionsMode>.Set(JSObject, "mode", value);
    }
}

#nullable disable