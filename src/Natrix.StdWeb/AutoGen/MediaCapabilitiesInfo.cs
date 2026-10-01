// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaCapabilitiesInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaCapabilitiesInfo>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilitiesInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaCapabilitiesInfo global::Natrix.JSCore.IJSObjectProxy<MediaCapabilitiesInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilitiesInfo(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool Supported
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "supported");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "supported", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool Smooth
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "smooth");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "smooth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool PowerEfficient
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "powerEfficient");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "powerEfficient", value);
    }
}

#nullable disable