// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RsaHashedKeyAlgorithm: global::Natrix.StdWeb.RsaKeyAlgorithm, global::Natrix.JSCore.IJSObjectProxy<RsaHashedKeyAlgorithm>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaHashedKeyAlgorithm(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RsaHashedKeyAlgorithm global::Natrix.JSCore.IJSObjectProxy<RsaHashedKeyAlgorithm>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaHashedKeyAlgorithm(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.KeyAlgorithm Hash
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.KeyAlgorithm>.Get(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.KeyAlgorithm>.Set(JSObject, "hash", value);
    }
}

#nullable disable