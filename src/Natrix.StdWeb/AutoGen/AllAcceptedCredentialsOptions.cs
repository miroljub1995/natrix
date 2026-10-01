// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AllAcceptedCredentialsOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AllAcceptedCredentialsOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AllAcceptedCredentialsOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AllAcceptedCredentialsOptions global::Natrix.JSCore.IJSObjectProxy<AllAcceptedCredentialsOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AllAcceptedCredentialsOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string RpId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "rpId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "rpId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string UserId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "userId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "userId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> AllAcceptedCredentialIds
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "allAcceptedCredentialIds");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "allAcceptedCredentialIds", value);
    }
}

#nullable disable