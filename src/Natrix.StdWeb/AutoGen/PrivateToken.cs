// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PrivateToken: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PrivateToken>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PrivateToken(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PrivateToken global::Natrix.JSCore.IJSObjectProxy<PrivateToken>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PrivateToken(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.TokenVersion Version
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TokenVersion>.Get(JSObject, "version");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.TokenVersion>.Set(JSObject, "version", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.OperationType Operation
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OperationType>.Get(JSObject, "operation");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OperationType>.Set(JSObject, "operation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RefreshPolicy RefreshPolicy
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RefreshPolicy>.Get(JSObject, "refreshPolicy");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RefreshPolicy>.Set(JSObject, "refreshPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Issuers
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "issuers");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "issuers", value);
    }
}

#nullable disable