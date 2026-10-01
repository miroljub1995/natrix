// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IdentityProviderBranding: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IdentityProviderBranding>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdentityProviderBranding(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IdentityProviderBranding global::Natrix.JSCore.IJSObjectProxy<IdentityProviderBranding>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdentityProviderBranding(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Background_color
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "background_color");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "background_color", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Color
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "color");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "color", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.IdentityProviderIcon, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IdentityProviderIcon>> Icons
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.IdentityProviderIcon, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IdentityProviderIcon>>>.Get(JSObject, "icons");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.IdentityProviderIcon, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IdentityProviderIcon>>>.Set(JSObject, "icons", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }
}

#nullable disable