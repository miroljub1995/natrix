// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IdentityUserInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IdentityUserInfo>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdentityUserInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IdentityUserInfo global::Natrix.JSCore.IJSObjectProxy<IdentityUserInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdentityUserInfo(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Email
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "email");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "email", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string GivenName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "givenName");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "givenName", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Picture
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "picture");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "picture", value);
    }
}

#nullable disable