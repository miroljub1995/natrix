// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaKeyMessageEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<MediaKeyMessageEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaKeyMessageEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaKeyMessageEventInit global::Natrix.JSCore.IJSObjectProxy<MediaKeyMessageEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaKeyMessageEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaKeyMessageType MessageType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeyMessageType>.Get(JSObject, "messageType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeyMessageType>.Set(JSObject, "messageType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.ArrayBuffer Message
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Get(JSObject, "message");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>.Set(JSObject, "message", value);
    }
}

#nullable disable