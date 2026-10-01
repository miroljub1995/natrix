// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticationExtensionsLargeBlobOutputs: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsLargeBlobOutputs>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsLargeBlobOutputs(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticationExtensionsLargeBlobOutputs global::Natrix.JSCore.IJSObjectProxy<AuthenticationExtensionsLargeBlobOutputs>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticationExtensionsLargeBlobOutputs(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Supported
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "supported");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "supported", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer Blob
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "blob");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Set(JSObject, "blob", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Written
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "written");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "written", value);
    }
}

#nullable disable