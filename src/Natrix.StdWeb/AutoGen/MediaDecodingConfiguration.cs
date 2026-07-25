// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaDecodingConfiguration: global::Natrix.StdWeb.MediaConfiguration
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaDecodingConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaDecodingConfiguration(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaDecodingType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaDecodingType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "type");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaDecodingType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaCapabilitiesKeySystemConfiguration KeySystemConfiguration
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaCapabilitiesKeySystemConfiguration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "keySystemConfiguration");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaCapabilitiesKeySystemConfiguration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "keySystemConfiguration", value);
    }
}

#nullable disable