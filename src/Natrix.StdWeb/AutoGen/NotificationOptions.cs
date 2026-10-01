// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NotificationOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<NotificationOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NotificationOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NotificationOptions global::Natrix.JSCore.IJSObjectProxy<NotificationOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NotificationOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NotificationDirection Dir
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NotificationDirection>.Get(JSObject, "dir");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NotificationDirection>.Set(JSObject, "dir", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Lang
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "lang");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "lang", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Body
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "body");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "body", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Navigate
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "navigate");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "navigate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Tag
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "tag");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "tag", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Image
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "image");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "image", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Icon
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "icon");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "icon", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Badge
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "badge");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "badge", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<uint, global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>> Vibrate
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>>>.Get(JSObject, "vibrate");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<uint, global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>>>.Set(JSObject, "vibrate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Timestamp
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "timestamp");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "timestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Renotify
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "renotify");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "renotify", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool? Silent
    {
        get => global::Natrix.JSCore.Generics.NullableBooleanAccessor.Get(JSObject, "silent");
        set => global::Natrix.JSCore.Generics.NullableBooleanAccessor.Set(JSObject, "silent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RequireInteraction
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "requireInteraction");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "requireInteraction", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Data
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Set(JSObject, "data", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NotificationAction, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NotificationAction>> Actions
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NotificationAction, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NotificationAction>>>.Get(JSObject, "actions");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NotificationAction, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NotificationAction>>>.Set(JSObject, "actions", value);
    }
}

#nullable disable