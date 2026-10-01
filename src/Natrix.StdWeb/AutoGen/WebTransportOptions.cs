// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebTransportOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportOptions global::Natrix.JSCore.IJSObjectProxy<WebTransportOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AllowPooling
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "allowPooling");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "allowPooling", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RequireUnreliable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "requireUnreliable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "requireUnreliable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>, global::Natrix.JSCore.Generics.Record<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<string, global::Natrix.JSCore.Generics.StringAccessor>>> Headers
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>, global::Natrix.JSCore.Generics.Record<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<string, global::Natrix.JSCore.Generics.StringAccessor>>>>.Get(JSObject, "headers");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>, global::Natrix.JSCore.Generics.Record<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<string, global::Natrix.JSCore.Generics.StringAccessor>>>>.Set(JSObject, "headers", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebTransportHash, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportHash>> ServerCertificateHashes
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebTransportHash, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportHash>>>.Get(JSObject, "serverCertificateHashes");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebTransportHash, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportHash>>>.Set(JSObject, "serverCertificateHashes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebTransportCongestionControl CongestionControl
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WebTransportCongestionControl>.Get(JSObject, "congestionControl");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WebTransportCongestionControl>.Set(JSObject, "congestionControl", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? AnticipatedConcurrentIncomingUnidirectionalStreams
    {
        get => global::Natrix.JSCore.Generics.NullableUInt16Accessor.Get(JSObject, "anticipatedConcurrentIncomingUnidirectionalStreams");
        set => global::Natrix.JSCore.Generics.NullableUInt16Accessor.Set(JSObject, "anticipatedConcurrentIncomingUnidirectionalStreams", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? AnticipatedConcurrentIncomingBidirectionalStreams
    {
        get => global::Natrix.JSCore.Generics.NullableUInt16Accessor.Get(JSObject, "anticipatedConcurrentIncomingBidirectionalStreams");
        set => global::Natrix.JSCore.Generics.NullableUInt16Accessor.Set(JSObject, "anticipatedConcurrentIncomingBidirectionalStreams", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Protocols
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "protocols");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "protocols", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ReadableStreamType DatagramsReadableType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ReadableStreamType>.Get(JSObject, "datagramsReadableType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ReadableStreamType>.Set(JSObject, "datagramsReadableType", value);
    }
}

#nullable disable