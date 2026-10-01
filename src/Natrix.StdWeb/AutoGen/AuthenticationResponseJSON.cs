// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticationResponseJSON: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticationResponseJSON>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationResponseJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticationResponseJSON global::Natrix.JSCore.IJSObjectProxy<AuthenticationResponseJSON>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationResponseJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string RawId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "rawId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "rawId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.AuthenticatorAssertionResponseJSON Response
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticatorAssertionResponseJSON>.Get(JSObject, "response");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticatorAssertionResponseJSON>.Set(JSObject, "response", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AuthenticatorAttachment
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "authenticatorAttachment");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "authenticatorAttachment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.AuthenticationExtensionsClientOutputsJSON ClientExtensionResults
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsClientOutputsJSON>.Get(JSObject, "clientExtensionResults");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsClientOutputsJSON>.Set(JSObject, "clientExtensionResults", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }
}

#nullable disable