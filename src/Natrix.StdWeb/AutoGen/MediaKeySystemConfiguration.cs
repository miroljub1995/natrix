// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaKeySystemConfiguration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaKeySystemConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaKeySystemConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaKeySystemConfiguration global::Natrix.JSCore.IJSObjectProxy<MediaKeySystemConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaKeySystemConfiguration(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "label");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "label", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> InitDataTypes
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "initDataTypes");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "initDataTypes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaKeySystemMediaCapability, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemMediaCapability>> AudioCapabilities
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaKeySystemMediaCapability, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemMediaCapability>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaKeySystemMediaCapability, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemMediaCapability>>>>(JSObject, "audioCapabilities");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaKeySystemMediaCapability, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemMediaCapability>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaKeySystemMediaCapability, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemMediaCapability>>>>(JSObject, "audioCapabilities", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaKeySystemMediaCapability, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemMediaCapability>> VideoCapabilities
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaKeySystemMediaCapability, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemMediaCapability>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaKeySystemMediaCapability, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemMediaCapability>>>>(JSObject, "videoCapabilities");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaKeySystemMediaCapability, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemMediaCapability>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaKeySystemMediaCapability, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemMediaCapability>>>>(JSObject, "videoCapabilities", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaKeysRequirement DistinctiveIdentifier
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaKeysRequirement, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeysRequirement>>(JSObject, "distinctiveIdentifier");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaKeysRequirement, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeysRequirement>>(JSObject, "distinctiveIdentifier", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaKeysRequirement PersistentState
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaKeysRequirement, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeysRequirement>>(JSObject, "persistentState");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaKeysRequirement, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeysRequirement>>(JSObject, "persistentState", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> SessionTypes
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "sessionTypes");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "sessionTypes", value);
    }
}

#nullable disable