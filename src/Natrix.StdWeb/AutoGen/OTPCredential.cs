// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OTPCredential: global::Natrix.StdWeb.Credential, global::Natrix.JSCore.IJSObjectProxy<OTPCredential>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OTPCredential(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OTPCredential global::Natrix.JSCore.IJSObjectProxy<OTPCredential>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<OTPCredential>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Code
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "code");
    }
}

#nullable disable