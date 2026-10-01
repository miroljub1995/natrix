// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCDataChannelInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCDataChannelInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCDataChannelInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCDataChannelInit global::Natrix.JSCore.IJSObjectProxy<RTCDataChannelInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCDataChannelInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCPriorityType Priority
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCPriorityType>.Get(JSObject, "priority");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCPriorityType>.Set(JSObject, "priority", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Ordered
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ordered");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ordered", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort MaxPacketLifeTime
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "maxPacketLifeTime");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "maxPacketLifeTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort MaxRetransmits
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "maxRetransmits");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "maxRetransmits", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Protocol
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "protocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Negotiated
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "negotiated");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "negotiated", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Id
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "id", value);
    }
}

#nullable disable