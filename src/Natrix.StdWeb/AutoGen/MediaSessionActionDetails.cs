// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaSessionActionDetails: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaSessionActionDetails>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaSessionActionDetails(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaSessionActionDetails global::Natrix.JSCore.IJSObjectProxy<MediaSessionActionDetails>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaSessionActionDetails(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaSessionAction Action
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaSessionAction>.Get(JSObject, "action");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaSessionAction>.Set(JSObject, "action", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double SeekOffset
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "seekOffset");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "seekOffset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double SeekTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "seekTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "seekTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool FastSeek
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "fastSeek");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "fastSeek", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsActivating
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isActivating");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isActivating", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSessionEnterPictureInPictureReason EnterPictureInPictureReason
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaSessionEnterPictureInPictureReason>.Get(JSObject, "enterPictureInPictureReason");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaSessionEnterPictureInPictureReason>.Set(JSObject, "enterPictureInPictureReason", value);
    }
}

#nullable disable