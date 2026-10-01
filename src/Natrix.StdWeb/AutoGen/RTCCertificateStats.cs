// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCCertificateStats: global::Natrix.StdWeb.RTCStats, global::Natrix.JSCore.IJSObjectProxy<RTCCertificateStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCCertificateStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCCertificateStats global::Natrix.JSCore.IJSObjectProxy<RTCCertificateStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCCertificateStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Fingerprint
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "fingerprint");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "fingerprint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string FingerprintAlgorithm
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "fingerprintAlgorithm");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "fingerprintAlgorithm", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Base64Certificate
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "base64Certificate");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "base64Certificate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string IssuerCertificateId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "issuerCertificateId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "issuerCertificateId", value);
    }
}

#nullable disable