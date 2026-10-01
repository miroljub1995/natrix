// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticationExtensionsPRFValuesJSON: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsPRFValuesJSON>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsPRFValuesJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticationExtensionsPRFValuesJSON global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsPRFValuesJSON>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsPRFValuesJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string First
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "first");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "first", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Second
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "second");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "second", value);
    }
}

#nullable disable