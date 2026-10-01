// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PublicKeyCredentialRequestOptionsJSON: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PublicKeyCredentialRequestOptionsJSON>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PublicKeyCredentialRequestOptionsJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PublicKeyCredentialRequestOptionsJSON global::Natrix.JSCore.IJSObjectProxy<PublicKeyCredentialRequestOptionsJSON>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PublicKeyCredentialRequestOptionsJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Challenge
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "challenge");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "challenge", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Timeout
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "timeout");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "timeout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RpId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "rpId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "rpId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON>> AllowCredentials
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON>>>.Get(JSObject, "allowCredentials");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PublicKeyCredentialDescriptorJSON>>>.Set(JSObject, "allowCredentials", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UserVerification
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "userVerification");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "userVerification", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Hints
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "hints");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "hints", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AuthenticationExtensionsClientInputsJSON Extensions
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsClientInputsJSON>.Get(JSObject, "extensions");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AuthenticationExtensionsClientInputsJSON>.Set(JSObject, "extensions", value);
    }
}

#nullable disable