// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RsaHashedKeyAlgorithm: global::Natrix.StdWeb.RsaKeyAlgorithm
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaHashedKeyAlgorithm(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaHashedKeyAlgorithm(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.KeyAlgorithm Hash
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.KeyAlgorithm, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.KeyAlgorithm, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hash", value);
    }
}

#nullable disable