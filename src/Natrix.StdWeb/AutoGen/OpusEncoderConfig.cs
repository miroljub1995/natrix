// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OpusEncoderConfig: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<OpusEncoderConfig>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OpusEncoderConfig(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OpusEncoderConfig global::Natrix.JSCore.IJSObjectProxy<OpusEncoderConfig>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OpusEncoderConfig(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.OpusBitstreamFormat Format
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OpusBitstreamFormat>.Get(JSObject, "format");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OpusBitstreamFormat>.Set(JSObject, "format", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.OpusSignal Signal
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OpusSignal>.Get(JSObject, "signal");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OpusSignal>.Set(JSObject, "signal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.OpusApplication Application
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OpusApplication>.Get(JSObject, "application");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.OpusApplication>.Set(JSObject, "application", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong FrameDuration
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "frameDuration");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "frameDuration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Complexity
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "complexity");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "complexity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Packetlossperc
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "packetlossperc");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "packetlossperc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Useinbandfec
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "useinbandfec");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "useinbandfec", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Usedtx
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "usedtx");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "usedtx", value);
    }
}

#nullable disable