// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AesKeyAlgorithm: global::Natrix.StdWeb.KeyAlgorithm, global::Natrix.JSCore.IJSObjectProxy<AesKeyAlgorithm>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AesKeyAlgorithm(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AesKeyAlgorithm global::Natrix.JSCore.IJSObjectProxy<AesKeyAlgorithm>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AesKeyAlgorithm(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required ushort Length
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "length");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "length", value);
    }
}

#nullable disable