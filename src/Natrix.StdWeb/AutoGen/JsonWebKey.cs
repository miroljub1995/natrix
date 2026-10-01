// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class JsonWebKey: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<JsonWebKey>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public JsonWebKey(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static JsonWebKey global::Natrix.JSCore.IJSObjectProxy<JsonWebKey>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public JsonWebKey(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Kty
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "kty");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "kty", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Use
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "use");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "use", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Key_ops
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "key_ops");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "key_ops", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Alg
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "alg");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "alg", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Ext
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ext");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ext", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Crv
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "crv");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "crv", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string X
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "x");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "x", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Y
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "y");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "y", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string D
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "d");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "d", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string N
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "n");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "n", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string E
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "e");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "e", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string P
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "p");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "p", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Q
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "q");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "q", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Dp
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "dp");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "dp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Dq
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "dq");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "dq", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Qi
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "qi");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "qi", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RsaOtherPrimesInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RsaOtherPrimesInfo>> Oth
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RsaOtherPrimesInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RsaOtherPrimesInfo>>>.Get(JSObject, "oth");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RsaOtherPrimesInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RsaOtherPrimesInfo>>>.Set(JSObject, "oth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string K
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "k");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "k", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Pub
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "pub");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "pub", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Priv
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "priv");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "priv", value);
    }
}

#nullable disable