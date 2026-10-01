// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class KmacKeyAlgorithm: global::Natrix.StdWeb.KeyAlgorithm, global::Natrix.JSCore.IJSObjectProxy<KmacKeyAlgorithm>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KmacKeyAlgorithm(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static KmacKeyAlgorithm global::Natrix.JSCore.IJSObjectProxy<KmacKeyAlgorithm>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public KmacKeyAlgorithm(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Length
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "length");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "length", value);
    }
}

#nullable disable