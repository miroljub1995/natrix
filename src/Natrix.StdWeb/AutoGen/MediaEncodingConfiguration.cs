// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaEncodingConfiguration: global::Natrix.StdWeb.MediaConfiguration, global::Natrix.JSCore.IJSObjectProxy<MediaEncodingConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaEncodingConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaEncodingConfiguration global::Natrix.JSCore.IJSObjectProxy<MediaEncodingConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaEncodingConfiguration(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaEncodingType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaEncodingType>.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaEncodingType>.Set(JSObject, "type", value);
    }
}

#nullable disable