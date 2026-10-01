// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaCapabilitiesKeySystemConfiguration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaCapabilitiesKeySystemConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilitiesKeySystemConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaCapabilitiesKeySystemConfiguration global::Natrix.JSCore.IJSObjectProxy<MediaCapabilitiesKeySystemConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaCapabilitiesKeySystemConfiguration(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string KeySystem
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "keySystem");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "keySystem", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string InitDataType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "initDataType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "initDataType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaKeysRequirement DistinctiveIdentifier
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeysRequirement>.Get(JSObject, "distinctiveIdentifier");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeysRequirement>.Set(JSObject, "distinctiveIdentifier", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaKeysRequirement PersistentState
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeysRequirement>.Get(JSObject, "persistentState");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeysRequirement>.Set(JSObject, "persistentState", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> SessionTypes
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "sessionTypes");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "sessionTypes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.KeySystemTrackConfiguration Audio
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.KeySystemTrackConfiguration>.Get(JSObject, "audio");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.KeySystemTrackConfiguration>.Set(JSObject, "audio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.KeySystemTrackConfiguration Video
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.KeySystemTrackConfiguration>.Get(JSObject, "video");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.KeySystemTrackConfiguration>.Set(JSObject, "video", value);
    }
}

#nullable disable