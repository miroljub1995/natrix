// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class EcdhKeyDeriveParams: global::Natrix.StdWeb.Algorithm
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EcdhKeyDeriveParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public EcdhKeyDeriveParams(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.CryptoKey Public
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CryptoKey, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "public");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CryptoKey, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "public", value);
    }
}

#nullable disable