// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaCapabilitiesEncodingInfo: global::Natrix.StdWeb.MediaCapabilitiesInfo, global::Natrix.JSCore.IJSObjectProxy<MediaCapabilitiesEncodingInfo>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilitiesEncodingInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaCapabilitiesEncodingInfo global::Natrix.JSCore.IJSObjectProxy<MediaCapabilitiesEncodingInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilitiesEncodingInfo(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaEncodingConfiguration Configuration
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaEncodingConfiguration>.Get(JSObject, "configuration");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaEncodingConfiguration>.Set(JSObject, "configuration", value);
    }
}

#nullable disable