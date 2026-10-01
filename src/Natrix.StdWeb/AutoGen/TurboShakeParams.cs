// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TurboShakeParams: global::Natrix.StdWeb.Algorithm, global::Natrix.JSCore.IJSObjectProxy<TurboShakeParams>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TurboShakeParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TurboShakeParams global::Natrix.JSCore.IJSObjectProxy<TurboShakeParams>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TurboShakeParams(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint OutputLength
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "outputLength");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "outputLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte DomainSeparation
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "domainSeparation");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "domainSeparation", value);
    }
}

#nullable disable