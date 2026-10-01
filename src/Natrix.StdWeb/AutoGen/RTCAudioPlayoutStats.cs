// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCAudioPlayoutStats: global::Natrix.StdWeb.RTCStats, global::Natrix.JSCore.IJSObjectProxy<RTCAudioPlayoutStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCAudioPlayoutStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCAudioPlayoutStats global::Natrix.JSCore.IJSObjectProxy<RTCAudioPlayoutStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCAudioPlayoutStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Kind
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "kind");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "kind", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double SynthesizedSamplesDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "synthesizedSamplesDuration");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "synthesizedSamplesDuration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SynthesizedSamplesEvents
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "synthesizedSamplesEvents");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "synthesizedSamplesEvents", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalSamplesDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalSamplesDuration");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalSamplesDuration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalPlayoutDelay
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalPlayoutDelay");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalPlayoutDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong TotalSamplesCount
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "totalSamplesCount");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "totalSamplesCount", value);
    }
}

#nullable disable