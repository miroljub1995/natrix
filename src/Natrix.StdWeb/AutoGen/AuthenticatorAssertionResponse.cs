// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AuthenticatorAssertionResponse: global::Natrix.StdWeb.AuthenticatorResponse
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AuthenticatorAssertionResponse(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer AuthenticatorData
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "authenticatorData");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer Signature
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "signature");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.ArrayBuffer? UserHandle
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.ArrayBuffer?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "userHandle");
    }
}

#nullable disable