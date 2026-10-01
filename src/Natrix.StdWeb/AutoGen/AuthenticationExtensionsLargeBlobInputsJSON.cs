// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticationExtensionsLargeBlobInputsJSON: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsLargeBlobInputsJSON>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsLargeBlobInputsJSON(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticationExtensionsLargeBlobInputsJSON global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsLargeBlobInputsJSON>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsLargeBlobInputsJSON(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Support
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "support");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "support", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Read
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "read");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "read", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Write
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "write");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "write", value);
    }
}

#nullable disable