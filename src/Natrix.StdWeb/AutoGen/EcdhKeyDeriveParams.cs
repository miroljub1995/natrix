// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EcdhKeyDeriveParams: global::Natrix.StdWeb.Algorithm, global::Natrix.JSCore.IJSObjectProxy<EcdhKeyDeriveParams>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EcdhKeyDeriveParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static EcdhKeyDeriveParams global::Natrix.JSCore.IJSObjectProxy<EcdhKeyDeriveParams>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EcdhKeyDeriveParams(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.CryptoKey Public
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CryptoKey, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CryptoKey>>(JSObject, "public");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CryptoKey, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CryptoKey>>(JSObject, "public", value);
    }
}

#nullable disable