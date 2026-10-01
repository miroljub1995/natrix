// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RsaKeyGenParams: global::Natrix.StdWeb.Algorithm, global::Natrix.JSCore.IJSObjectProxy<RsaKeyGenParams>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaKeyGenParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RsaKeyGenParams global::Natrix.JSCore.IJSObjectProxy<RsaKeyGenParams>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RsaKeyGenParams(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint ModulusLength
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "modulusLength");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "modulusLength", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Uint8Array PublicExponent
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>.Get(JSObject, "publicExponent");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>.Set(JSObject, "publicExponent", value);
    }
}

#nullable disable