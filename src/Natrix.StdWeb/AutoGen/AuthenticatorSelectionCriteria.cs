// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticatorSelectionCriteria: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticatorSelectionCriteria>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticatorSelectionCriteria(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticatorSelectionCriteria global::Natrix.JSCore.IJSObjectProxy<AuthenticatorSelectionCriteria>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticatorSelectionCriteria(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AuthenticatorAttachment
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "authenticatorAttachment");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "authenticatorAttachment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ResidentKey
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "residentKey");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "residentKey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RequireResidentKey
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "requireResidentKey");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "requireResidentKey", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UserVerification
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "userVerification");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "userVerification", value);
    }
}

#nullable disable