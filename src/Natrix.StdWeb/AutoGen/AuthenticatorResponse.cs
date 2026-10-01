// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticatorResponse: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AuthenticatorResponse>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticatorResponse(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AuthenticatorResponse global::Natrix.JSCore.IJSObjectProxy<AuthenticatorResponse>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AuthenticatorResponse>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer ClientDataJSON
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "clientDataJSON");
    }
}

#nullable disable