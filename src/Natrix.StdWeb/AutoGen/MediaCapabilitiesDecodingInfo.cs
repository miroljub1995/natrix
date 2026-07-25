// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaCapabilitiesDecodingInfo: global::Natrix.StdWeb.MediaCapabilitiesInfo
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilitiesDecodingInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilitiesDecodingInfo(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaKeySystemAccess? KeySystemAccess
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaKeySystemAccess?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "keySystemAccess");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaKeySystemAccess?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "keySystemAccess", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaDecodingConfiguration Configuration
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaDecodingConfiguration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "configuration");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaDecodingConfiguration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "configuration", value);
    }
}

#nullable disable