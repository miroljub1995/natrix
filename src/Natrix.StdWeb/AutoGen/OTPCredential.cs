// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OTPCredential: global::Natrix.StdWeb.Credential
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OTPCredential(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Code
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "code");
    }
}

#nullable disable