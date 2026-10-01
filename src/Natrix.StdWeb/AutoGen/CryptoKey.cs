// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CryptoKey: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CryptoKey>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CryptoKey(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CryptoKey global::Natrix.JSCore.IJSObjectProxy<CryptoKey>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CryptoKey>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.KeyType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.KeyType>.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Extractable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "extractable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Algorithm
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "algorithm");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject Usages
    {
        get => global::Natrix.JSCore.Generics.JSObjectAccessor.Get(JSObject, "usages");
    }
}

#nullable disable