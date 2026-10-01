// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RsaPssParams: global::Natrix.StdWeb.Algorithm, global::Natrix.JSCore.IJSObjectProxy<RsaPssParams>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaPssParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RsaPssParams global::Natrix.JSCore.IJSObjectProxy<RsaPssParams>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaPssParams(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint SaltLength
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "saltLength");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "saltLength", value);
    }
}

#nullable disable