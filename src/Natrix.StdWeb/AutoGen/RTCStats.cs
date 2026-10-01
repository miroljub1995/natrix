// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCStats: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCStats global::Natrix.JSCore.IJSObjectProxy<RTCStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCStats(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double Timestamp
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "timestamp");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "timestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCStatsType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCStatsType>.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCStatsType>.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }
}

#nullable disable