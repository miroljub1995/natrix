// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaCapabilitiesDecodingInfo: global::Natrix.StdWeb.MediaCapabilitiesInfo, global::Natrix.JSCore.IJSObjectProxy<MediaCapabilitiesDecodingInfo>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilitiesDecodingInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaCapabilitiesDecodingInfo global::Natrix.JSCore.IJSObjectProxy<MediaCapabilitiesDecodingInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilitiesDecodingInfo(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaKeySystemAccess? KeySystemAccess
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.MediaKeySystemAccess>.Get(JSObject, "keySystemAccess");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.MediaKeySystemAccess>.Set(JSObject, "keySystemAccess", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaDecodingConfiguration Configuration
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaDecodingConfiguration>.Get(JSObject, "configuration");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaDecodingConfiguration>.Set(JSObject, "configuration", value);
    }
}

#nullable disable