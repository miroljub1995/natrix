// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HmacKeyAlgorithm: global::Natrix.StdWeb.KeyAlgorithm, global::Natrix.JSCore.IJSObjectProxy<HmacKeyAlgorithm>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HmacKeyAlgorithm(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HmacKeyAlgorithm global::Natrix.JSCore.IJSObjectProxy<HmacKeyAlgorithm>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HmacKeyAlgorithm(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.KeyAlgorithm Hash
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.KeyAlgorithm, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.KeyAlgorithm>>(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.KeyAlgorithm, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.KeyAlgorithm>>(JSObject, "hash", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Length
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "length");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "length", value);
    }
}

#nullable disable